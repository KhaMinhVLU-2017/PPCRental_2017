Feature: BCA2ViewListProject
		Allow all user see List Project

Background: I have data of project
Given I Have Data of Project
	 | PropertyName              | Avatar        | Images        | Content                                                                                                                                                            | Status_Name |
	 | Căn hộ Enterprise City    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | PIS Top Apartment		 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Bigroom with Riverview	 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Phú Mỹ Hưng Quận 7		 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Scala Quận 9				 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Căn hộ Enterprise City 25 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |

Scenario: All User see List Project
	When I go to Home Page
	Then I see List Project 
	 | PropertyName              | Avatar        | Images        | Content                                                                                                                                                            | Status_Name |
	 | Căn hộ Enterprise City    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | PIS Top Apartment		 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |
	 | Bigroom with Riverview	 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    |