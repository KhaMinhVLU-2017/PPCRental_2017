#add @web tag to run the search tests with Selenium automation

#@automated
@web
Feature: US01_FilterProject
	As a potential customer
	I want to search for property by a simple phrase
	So that I can easily allocate property by something I remember from them.

Background:
	Given the following property
	| PropertyName                                                        | PropertyType | Street           | Ward          | District        |
	| Căn hộ Enterprise City                                              | Apartment    | Đường số 6       | P.13          | Quận 1          |
	| Topaz Elite mở Bán Block Cuối Cùng Đẹp NhấtDự Án "dragon 1"         | Apartment    | Cao lỗ           | P.7           | Quận 8          |
	| Nhà Phố 3 tầng cao cấp gần khu trung tâm quận 10 và quận 1và quận 5 | House        | Cao lỗ           | P.4           | Quận 8          |
	| Căn hộ The Gold View                                                | Apartment    | Bền Vân Đồn      | P.01          | Quận 7          |
	| Biệt thự lô góc cực đẹp                                             | Villa        | Huỳnh Tấn Phát   | P.Phú Mỹ      | Quận 7          |
	| BÁN CĂN HỘ 01 PHÒNG NGỦ Ở VINHOMES CENTRAL PARK                     | Apartment    | Điện Biên Phủ    | P.22          | Quận Bình Thạnh |
	| Biệt thự Saroma Sala Đại Quang Minh                                 | Villa        | Xa Lộ Hà Nội     | P.08          | Quận 2          |
	| Shophouse nhà phố Sala                                              | House        | Xa Lộ Hà Nội     | P.08          | Quận 2          |
	| Shop Apartment Sala 1 trệt 2 lầu                                    | House        | Xa Lộ Hà Nội     | P.08          | Quận 2          |
	| Căn hộ Sarimi phòng ngủ full nội thất                               | Apartment    | Xa Lộ Hà Nội     | P.08          | Quận 2          |
	| Căn hộ Phú Mỹ Hưng                                                  | Apartment    | Đường Số 14      | P.Phú Mỹ      | Quận 7          |
	| ĐÔNG NAM DỰ ÁN BOTANICA PREMIER                                     | Office       | Hồng Hà          | P.2           | Quận Tân Bình   |
	| CĂN HỘ ĐƯỜNG CỘNG HÒA                                               | Apartment    | Cộng Hòa         | P.2           | Quận Tân Bình   |
	| CĂN HỘ PENTHOUSE DUPLEX BẢY HIỀN TOWER                              | House        | Cộng Hòa         | P.11          | Quận Tân Bình   |
	| CĂN HỘ MADISON QUẬN 1                                               | Office       | Phùng Khắc Khoan | P.08          | Quận 1          |
	| VINHOMES ĐỒNG KHỞI                                                  | Apartment    | Lê Thánh Tôn     | P.Bến Nghé    | Quận 1          |
	| BIỆT THỰ VINHOMES CENTRAL PARK                                      | Villa        | Điện Biên Phủ    | P.22          | Quận Bình Thạnh |
	| CĂN HỘ DRAGON RIVERSIDE CITY QUẬN 5                                 | Apartment    | Võ Văn Kiệt      | P.01          | Quận 5          |
	| HÀ ĐÔ CENTROSA GARDEN QUẬN 10                                       | Office       | 3 Tháng 2        | Xuân Thới Sơn | Quận 10         |


@mytag
Scenario: Title should be matched
	Given I search for property by the phrase 'Enterprise'
	When I press "Tim kiem"
	Then the list of found property should contain only: 'Căn hộ Enterprise City '
