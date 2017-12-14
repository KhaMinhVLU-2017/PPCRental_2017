Feature: ViewListProject
	The agency would like to see its list of projects in the site

Background: 
	Given the following project
		| Name Project                           | Avatar | Price  | Area | Date create | Note | Date Update | Email                  | Status   |
		| Căn hộ The Gold View                   | Avatar | 200000 | 70   |             | Done |             | anhphuong123@gmail.com | Đã duyệt |
		| ĐÔNG NAM DỰ ÁN BOTANICA PREMIER        | Avatar | 200000 | 92   |             | Done |             | anhphuong123@gmail.com | Đã duyệt |
		| CĂN HỘ PENTHOUSE DUPLEX BẢY HIỀN TOWER | Avatar | 280000 | 170  |             | Done |             | anhphuong123@gmail.com | Đã duyệt |
	

Scenario: Agency see list project of Agency
	Given Agency at the login page
	When Agency login with 'anhphuong123@gmail.com' and '123456789'
	Then Agency should see his own project list
		| Name Project                           | Avatar | Price  | Area | Date create | Note | Date Update | Email                  | Status   |
		| Căn hộ The Gold View                   | Avatar | 200000 | 70   |             | Done |             | anhphuong123@gmail.com | Đã duyệt |
		| ĐÔNG NAM DỰ ÁN BOTANICA PREMIER        | Avatar | 200000 | 92   |             | Done |             | anhphuong123@gmail.com | Đã duyệt |
		| CĂN HỘ PENTHOUSE DUPLEX BẢY HIỀN TOWER | Avatar | 280000 | 170  |             | Done |             | anhphuong123@gmail.com | Đã duyệt |