DROP TABLE IF EXISTS `orders_products`;
DROP TABLE IF EXISTS `products`;
DROP TABLE IF EXISTS `orders`;
DROP TABLE IF EXISTS `customers`;

CREATE TABLE `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(60) NOT NULL,
  `price` decimal(7,2) NOT NULL,
  `is_available` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `customers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(20) NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  FOREIGN KEY (`customer_id`) REFERENCES `customers`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `orders_products` (
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  FOREIGN KEY (`order_id`) REFERENCES `orders`(`id`),
  FOREIGN KEY (`product_id`) REFERENCES `products`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `products` VALUES (1, 'AMD - Ryzen', '1200', 1);
INSERT INTO `products` VALUES (2, 'CORSAIR - Power Supply', 400, 1);
INSERT INTO `products` VALUES (3, 'CORSAIR - 16GB 2.4GHz DDR4 Desktop Memory', 400, 1);
INSERT INTO `products` VALUES (4, 'Intel - Core i7-8700K', 1000, 0);
INSERT INTO `products` VALUES (5, 'ASUS - ROG Motherboard with LED Lighting', 800, 1);

INSERT INTO `customers` VALUES (1, 'user1234', '666555444');
INSERT INTO `customers` VALUES (2, 'random person', '555666444');

INSERT INTO `orders` VALUES (1, 1);
INSERT INTO `orders` VALUES (2, 1);
INSERT INTO `orders` VALUES (3, 2);

INSERT INTO `orders_products` VALUES (1, 1);
INSERT INTO `orders_products` VALUES (1, 2);
INSERT INTO `orders_products` VALUES (1, 3);
INSERT INTO `orders_products` VALUES (2, 5);
INSERT INTO `orders_products` VALUES (3, 2);
