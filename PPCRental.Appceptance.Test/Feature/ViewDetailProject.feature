#add @web tag to run the search tests with Selenium automation

#@web
@automated

Feature: ViewDetailProject
	Allow User see Detail of project


Background: Home Page include 
	Given I have home page of Projejct
	 |PropertyName			    | Avatar        | Images        | Content                                                                                                                                                            | Street_ID | Ward_ID | Dictrict_ID | Price  | UnitPrice | Area | BebRoom | BathRoom | PackingPlace | UserID |
	 | Căn hộ Enterprise City   | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | 3387      | 761     | 36          | 200000 | USD       | 99   | 2       | 2        | 1            | 1      |
	 | Căn hộ Enterprise City 22| Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | 3387      | 761     | 36          | 200000 | USD       | 99   | 2       | 2        | 1            | 1      |
	 | Căn hộ Enterprise City 23| Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | 3387      | 761     | 36          | 200000 | USD       | 99   | 2       | 2        | 1            | 1      |
	 | Căn hộ Enterprise City 24| Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | 3387      | 761     | 36          | 200000 | USD       | 99   | 2       | 2        | 1            | 1      |
	 | Căn hộ Enterprise City 25| Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | 3387      | 761     | 36          | 200000 | USD       | 99   | 2       | 2        | 1            | 1      |
	 | Căn hộ Enterprise City 25| Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | 3387      | 761     | 36          | 200000 | USD       | 99   | 2       | 2        | 1            | 1      |

		

Scenario: User see Detail of Project
	When User click 'Id Project' one any of project
	Then Show Detail Project
	| ID | PropertyName           | Avatar        | Images        | Content                                                                                                                                                            | Street_ID | Ward_ID | Dictrict_ID | Price  | UnitPrice | Area | BebRoom | BathRoom | PackingPlace | UserID |
	| 17 | Căn hộ Enterprise City | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | 3387      | 761     | 36          | 200000 | USD       | 99   | 2       | 2        | 1            | 1      |