/*
 Navicat Premium Data Transfer

 Source Server         : Localhost
 Source Server Type    : MySQL
 Source Server Version : 80018
 Source Host           : localhost:3306
 Source Schema         : zodiak

 Target Server Type    : MySQL
 Target Server Version : 80018
 File Encoding         : 65001

 Date: 27/03/2020 20:26:10
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for ramalan
-- ----------------------------
DROP TABLE IF EXISTS `ramalan`;
CREATE TABLE `ramalan` (
  `nama_zodiak` varchar(20) NOT NULL,
  `tanggal` varchar(30) NOT NULL,
  `ramalan` varchar(255) NOT NULL,
  `keuangan` varchar(255) NOT NULL,
  `kesehatan` varchar(255) NOT NULL,
  `angka_keberuntungan` int(11) NOT NULL,
  PRIMARY KEY (`nama_zodiak`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ramalan
-- ----------------------------
BEGIN;
INSERT INTO `ramalan` VALUES ('Libra', '', 'cuaca', 'Baik', 'Baik', 9211);
INSERT INTO `ramalan` VALUES ('Sagitarius', '2020-03-24', 'Baik', 'Baik', 'Baik', 921);
COMMIT;

SET FOREIGN_KEY_CHECKS = 1;
