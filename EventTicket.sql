-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 10 2025 г., 12:10
-- Версия сервера: 10.8.4-MariaDB
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `EventTicket`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Clients`
--

CREATE TABLE `Clients` (
  `Id` int(11) NOT NULL,
  `Surname` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Name` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Patronimyc` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Email` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Telephone` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Address` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `Clients`
--

INSERT INTO `Clients` (`Id`, `Surname`, `Name`, `Patronimyc`, `Email`, `Telephone`, `Address`) VALUES
(1, 'Валиуллин ', 'Владислав', 'Анатольевич', 'wladwaliullin@yandex.ru', '89124665480', 'г. Ижевск'),
(2, 'Иванов ', 'Иван', 'Иванович', 'ivanovivan@yandex.ru', '89991112233', 'г. Ижевск');

-- --------------------------------------------------------

--
-- Структура таблицы `Events`
--

CREATE TABLE `Events` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Date` date NOT NULL,
  `Time` time NOT NULL,
  `Place` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Ticket_Price` decimal(10,0) NOT NULL,
  `Seat_Amount` int(11) NOT NULL,
  `Description` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `Events`
--

INSERT INTO `Events` (`Id`, `Name`, `Date`, `Time`, `Place`, `Ticket_Price`, `Seat_Amount`, `Description`) VALUES
(1, 'Рок-концерт', '2025-03-07', '16:00:00', 'Подъезд', '5000', 10, 'Рок-концерт в подъезде');

-- --------------------------------------------------------

--
-- Структура таблицы `Orders`
--

CREATE TABLE `Orders` (
  `Id` int(11) NOT NULL,
  `Event_Id` int(11) DEFAULT NULL,
  `Ticket_Count` int(11) NOT NULL,
  `Order_Date` datetime DEFAULT current_timestamp(),
  `Order_Price` int(11) DEFAULT NULL,
  `Client_Id` int(11) DEFAULT NULL,
  `Status` varchar(63) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Note` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `Orders`
--

INSERT INTO `Orders` (`Id`, `Event_Id`, `Ticket_Count`, `Order_Date`, `Order_Price`, `Client_Id`, `Status`, `Note`) VALUES
(2, 1, 4, '2025-03-03 11:23:58', 20000, 1, 'ПРОДАН', 'ПИВО');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Clients`
--
ALTER TABLE `Clients`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `Events`
--
ALTER TABLE `Events`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `Orders`
--
ALTER TABLE `Orders`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_orders_client` (`Client_Id`),
  ADD KEY `fk_orders_events` (`Event_Id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Clients`
--
ALTER TABLE `Clients`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `Events`
--
ALTER TABLE `Events`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `Orders`
--
ALTER TABLE `Orders`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Orders`
--
ALTER TABLE `Orders`
  ADD CONSTRAINT `fk_orders_client` FOREIGN KEY (`Client_Id`) REFERENCES `Clients` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_orders_events` FOREIGN KEY (`Event_Id`) REFERENCES `Events` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
