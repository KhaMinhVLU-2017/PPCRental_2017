Feature: BCA4ViewListProjectAgency
	Allow Agency see All project about Agency Post

Background: I have a Project of Agency
Given All project posted of Agency
	 | PropertyName              | Avatar        | Images        | Content                                                                                                                                                            | Status_Name | UserID |
	 | Căn hộ Enterprise City    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | PIS Top Apartment         | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Bigroom with Riverview    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Phú Mỹ Hưng Quận 7        | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Scala Quận 9              | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Căn hộ Enterprise City 25 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |


Scenario: Agency see all project posted
	Given Agency have a HomePage         
	When  Agency go to Login with username 'shuu27897@gmail.com' and pass 'tiegviet'
	Then  All project of Agency show screen
	 | PropertyName              | Avatar        | Images        | Content                                                                                                                                                            | Status_Name | UserID |
	 | Căn hộ Enterprise City    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | PIS Top Apartment         | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Bigroom with Riverview    | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Phú Mỹ Hưng Quận 7        | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Scala Quận 9              | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |
	 | Căn hộ Enterprise City 25 | Sunrise01.JPG | Sunrise02.JPG | Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các trung tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart. | Đã duyệt    | 6      |