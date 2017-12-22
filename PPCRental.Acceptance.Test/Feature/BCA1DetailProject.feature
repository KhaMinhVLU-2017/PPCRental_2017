

Feature: BCA1.DetailProject
	Allow User see Detail of project


Background: Home Page include 
	Given I have home page of Projejct
	 | PropertyName              | Avatar        | Images        | Content                                                                                                                                                            | Status_Name |
	 | Căn hộ Enterprise City    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | PIS Top Apartment		 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Bigroom with Riverview	 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Căn hộ Enterprise City 24 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Căn hộ Enterprise City 25 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Căn hộ Enterprise City 25 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |

		

Scenario: User see Detail of Project
	When User click 'Căn hộ Enterprise City' one any of project
	Then Show Detail Project
	| PropertyName           | Avatar        | Images        | Content                                                                                                                                                            |Status_Name|
	| Căn hộ Enterprise City | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt  |