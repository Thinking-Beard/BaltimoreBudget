using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaltimoreBudget.Web.Models;

namespace BaltimoreBudget.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<BudgetItemModel>();

            //TODO: load from database

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "City Employees & Retirees",
               Amount = -6,
               Title = "Increase Deductibles and Co-Pays in employee health insurance plans",
               Description = "Increase co-pays and deductibles in retiree health insurance and prescription drug plans, bringing them more in line with neighboring counties.",
               TotalCategory = "Spending Cuts",
                FormId = "entry.0.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "City Employees & Retirees",
               Amount = -4,
               Title = "Stricter health benefit controls",
               Description = "Place stricter controls on the use of health benefits, such as prior authorization, drug quantity limits, and case management.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.1.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "City Employees & Retirees",
               Amount = -7,
               Title = "Increase the Portion of Health Insurance Premiums Paid by Retirees",
               Description = "Increase the portion of health insurance premiums paid by employees from 10-20% to 20-30%, depending on the plan they choose.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.2.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "City Employees & Retirees",
               Amount = -9,
               Title = "Freeze Pay for All but Lowest Paid Employees",
               Description = "Freeze pay for all but the lowest paid employees in Fiscal Year (FY) 2012. Pay was frozen for all employees in FY 2011.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.3.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "City Employees & Retirees",
               Amount = -10,
               Title = "Continue Furlough Plan",
                Description = "Continue the current furlough plan, which requires employees to take between four and eleven unpaid days off, depending on their salary.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.4.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "Public Safety",
               Amount = -13,
               Title = "Freeze police hiring 250 fewer hires",
                Description = "Freeze police hiring in FY 2012. This would mean 250 fewer hires than planned and leave the police force nearly 10% below authorized strength. This action would reduce police presence in neighborhoods and have a severe impact on the City’s crime fighting efforts.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.5.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "Public Safety",
               Amount = -1,
               Title = "Eliminate Police Marine Unit",
                Description = "Eliminate the Police marine unit and rely on the Fire Department, State DNR and US Coast Guard to respond to emergencies on the water.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.6.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "Public Safety",
               Amount = -0.5,
               Title = "Eliminate Mounted Police Unit",
                Description = "Eliminate the Police mounted horse unit. The mounted unit is used for crowd control, riot response, and ceremonial appearances.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.7.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "Public Safety",
               Amount = -0.5,
               Title = "Eliminate Special Traffic Enforcement Officers",
                Description = " Eliminate special enforcement officers. This will increase police overtime pay for emergency situations and special events. ",
                TotalCategory = "Spending Cuts",
                FormId = "entry.8.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
               BudgetGroup = "Public Safety",
               Amount = -4,
               Title = "Fire Company Closures",
                Description = "Permanently close the five least busy fire companies. The City is already operating rotating closures of three companies. Permanent closures would be made so as to minimize the impact on response times, but response times would suffer.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.9.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Public Safety",
                Amount = -2,
                Title = "Reduce Street Light Maintenance",
                Description = "Reduce street light maintenance and repair. Street lighting experienced a cut of $2.5 million in FY 2011. Further reductions in maintenance could create a large backlog of repair jobs that significantly reduce the quality of city lighting.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.10.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Arts & Learning",
                Amount = -5,
                Title = "Close 5 Libraries / Reduce Hours",
                Description = "Close the five least busy libraries and reduce hours at other branches. There are currently 22 library locations, so shutting down 5 will reduce access in the affected neighborhoods. Discontinuing services at loweruse locations permits the City to maintain better hours at other locations and buy books and materials for the smaller network.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.11.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Arts & Learning",
                Amount = -2.5,
                Title = "Reduce / Eliminate Grants to Museums & Orchestra",
                Description = " Reduce or eliminate grants to the City’s art museums and symphony orchestra, requiring them to charge (more) for services, raise more outside funds, or cut back the programs they offer.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.12.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Public Works",
                Amount = -0.5,
                Title = "Reduce Graffiti Removal",
                Description = "Reduce graffiti removal and seek community volunteers to remove graffiti in public places. There are currently l9 City positions responsible for graffiti removal.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.13.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Public Works",
                Amount = -1.5,
                Title = "Eliminate Business District Cleaning",
                Description = "Eliminate business district cleaning outside of downtown and rely on merchants associations to pay for the services.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.14.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Public Works",
                Amount = -3,
                Title = "Contract Mowing of Median Strips",
                Description = "Contract out the mowing of median strips. A contract would greatly reduce costs, though it would displace up to 32 City workers.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.15.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Public Works",
                Amount = -1,
                Title = "Discontinue Leaf Collection",
                Description = "Discontinue leaf collection. City residents would instead be responsible for composting or disposing leaves. Leaves that are not properly disposed of can increase stormwater runoff, block drainage of water, and clog water drainage systems.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.16.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Public Works",
                Amount = -1,
                Title = "Reduce Boarding & Cleaning of Vacant Properties",
                Description = "Reduce boarding and cleaning of vacant and abandoned properties. Vacant properties become locations for pests and transient populations if left unclean and unattended, affecting nearby properties. They can also become locations for illegal dumping.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.17.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Parks & Recreation",
                Amount = -1.5,
                Title = "Reduce City Park Maintenance",
                Description = "Reduce trash collection and ballfield and playground maintenance in City parks. Maintenance efforts would be reduced by 57%, continuing only for facilities programmed by the Baltimore City Recreation and Parks Department.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.18.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Parks & Recreation",
                Amount = -1,
                Title = "Close All But 6 City Pools",
                Description = "Close neighborhood swimming pools and operate only the six large park pools. In FY10, 62,000 City residents used these facilities, or about 10% of the population. The park pools have much higher use rates than the neighborhood pools. ",
                TotalCategory = "Spending Cuts",
                FormId = "entry.19.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Parks & Recreation",
                Amount = -3.5,
                Title = "Reduce Funding for After-School & Sports Programs",
                Description = "Reduce funding for after-school and sports programs for youth.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.20.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Parks & Recreation",
                Amount = -3,
                Title = "Close Some Rec. Centers & Improve Remainder",
                Description = "Close the least utilized recreation centers and improve the centers that remain open. The City currently operates 55 centers, a number which has not changed much with population loss. This leaves a large number of centers with shoestring budgets, insufficient staff, and deficient program conditions. Redirecting some savings can improve the quality of programs at those recreation centers which remain open. ",
                TotalCategory = "Spending Cuts",
                FormId = "entry.21.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -1,
                Title = "Reduce 311 Call Center Hours",
                Description = "Reduce 311 call center hours. Call Centers currently operate 16 hours a day. The new schedule would be ten hours a day Monday thru Friday and eight hours a day on the weekends, with the 311 service also offered online. ",
                TotalCategory = "Spending Cuts",
                FormId = "entry.22.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -0.5,
                Title = "Turn Off City Cable TV",
                Description = "Turn off the City cable television channel.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.23.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -0.5,
                Title = "Reduce Custodial Service in City Facilities",
                Description = "Reduce custodial services in City buildings and leave more building maintenance as the responsibility of employees (throwing away trash in common receptacles, shutting off lights, etc.).",
                TotalCategory = "Spending Cuts",
                FormId = "entry.24.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -3.5,
                Title = "Reduce Street Repair",
                Description = "Reduce street repair and resurfacing. This would reduce the number of lane miles resurfaced by in house crews from 50 to 24 per year and lengthen response times for pothole repairs. ",
                TotalCategory = "Spending Cuts",
                FormId = "entry.25.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -3,
                Title = "Discontinue Support for Small & Emerging Businesses",
                Description = "Discontinue support for programs to nurture small and emerging businesses.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.26.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -5,
                Title = "Cut agency admin budgets",
                Description = " Cut agency administrative budgets by 10%. This would impact fiscal, human resources, information technology and other functions that support front-line services.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.27.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -1,
                Title = "Reduce Election Funding",
                Description = "Reduce funding for the conduct of elections. Doing so will likely reduce polling sites and lead to longer lines during elections.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.28.single"
            });

            model.Add(new BudgetItemModel()
            {
                Selected = true,
                BudgetGroup = "Other City Services",
                Amount = -1,
                Title = "Reduce Convention Center Funding",
                Description = "Reduce funding for Convention Center improvements.",
                TotalCategory = "Spending Cuts",
                FormId = "entry.29.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 1,
                Title = "Bulk Trash Service Fee",
                Description = "Charge residents for bulk trash pickup. Residents could drop their trash at any of five locations if they do not want to pay the fee.",
                TotalCategory = "New Revenue",
                FormId = "entry.30.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 7,
                Title = "Two Cent Property Tax Increase",
                Description = "Increase the property tax rate by two cents per $100. The current rate in Baltimore is $2.268 per $100, the highest in the State of Maryland and more than double neighboring Baltimore County.",
                TotalCategory = "New Revenue",
                FormId = "entry.31.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 1,
                Title = "Introduce a Billboard Tax",
                Description = "Introduce a tax on billboards. There is currently no tax on billboard.",
                TotalCategory = "New Revenue",
                FormId = "entry.32.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 1,
                Title = "Grocery Bag Tax",
                Description = "Introduce a five cent tax on plastic grocery bags, with exemptions for WIC and food stamp recipients. The tax would discourage the use of environmentally unfriendly plastic bags. ",
                TotalCategory = "New Revenue",
                FormId = "entry.33.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 4,
                Title = "Increase Beverage Tax to 4 cents per dollar",
                Description = "Increase the beverage tax from two to four cents per container, exempting milk, juice and containers larger than 2 liters. This tax was just introduced in 2010.",
                TotalCategory = "New Revenue",
                FormId = "entry.34.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 1,
                Title = "$1 Fee for Circulator",
                Description = " Charge $1 to ride the Charm City Circulator bus, which is currently free. The Charm City Circulator provides free access to downtown and certain neighborhoods for tourists and City residents.",
                TotalCategory = "New Revenue",
                FormId = "entry.35.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 8,
                Title = "Stormwater Fee",
                Description = "Charge residents a stormwater fee based on property size to pay for projects that help the City meet federal clean water mandates.",
                TotalCategory = "New Revenue",
                FormId = "entry.36.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Revenue",
                Amount = 5,
                Title = "Increase Energy Tax by 25%",
                Description = "Increase the Energy Tax by 25%. This tax appears on a City resident's home energy bill, and was increased last year by 15%. The higher rate would cost the typical resident about $5 more a month and could promote energy conservation.",
                TotalCategory = "New Revenue",
                FormId = "entry.37.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -4,
                Title = "Stop Rotating Fire Company Closures",
                Description = "Eliminate rotating fire company closures. The current plan temporarily closes three fire companies at a time on a rotating basis.",
                TotalCategory = "New Spending",
                FormId = "entry.38.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -2.5,
                Title = "Increase Fudning for After-School Programs",
                Description = "Increase funding for after-school programs.",
                TotalCategory = "New Spending",
                FormId = "entry.39.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -2,
                Title = "Fully Fund Prosecutors",
                Description = "Fully fund prosecutor positions in the State Attomey’s office. Positions have been frozen for three years.",
                TotalCategory = "New Spending",
                FormId = "entry.40.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -2.5,
                Title = "Increase Lane Miles Resurfaced",
                Description = "Increase the number of lane miles resurfaced.",
                TotalCategory = "New Spending",
                FormId = "entry.41.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -1.5,
                Title = "Restore Tree Planting & Maintenance",
                Description = "Restore tree planting and maintenance.",
                TotalCategory = "New Spending",
                FormId = "entry.42.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -1,
                Title = "Increase Funding for Economic Development",
                Description = "Increase funding for economic development. Development activities include business retention and attraction, job creation, and enhancing neighborhood main streets.",
                TotalCategory = "New Spending",
                FormId = "entry.43.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -1,
                Title = "Extend City Pool Season",
                Description = "Extend the City pool season to ten weeks. The current budget supports a six week season from late June to mid-August ",
                TotalCategory = "New Spending",
                FormId = "entry.44.single"
            });

            model.Add(new BudgetItemModel()
            {
                BudgetGroup = "Spending Increases",
                Amount = -7,
                Title = "Reduce Property Tax by Two Cents",
                Description = "Reduce the property tax rate by two cents per $100.",
                TotalCategory = "New Spending",
                FormId = "entry.45.single"
            });

            return View(model);
        }

    }
}
