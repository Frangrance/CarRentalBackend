using Core.DataAccess.EntityFramework;
using Core.Utilities.Uploaders;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (var context = new ReCapProjectDbContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = car.BrandId,
                                 ColorId = car.ColorId,
                                 BrandName = brand.Name,
                                 Description = car.Description,
                                 ColorName = color.Name,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 FindexPoint = car.FindexPoint,
                                 CarImages = (from carImage in context.CarImages where car.Id == carImage.CarId select carImage).ToList().Count > 0
                                 ? (from carImage in context.CarImages where car.Id == carImage.CarId select carImage).ToList()
                                 : new List<CarImage> 
                                 { 
                                     new CarImage 
                                     { 
                                         CarId = car.Id,
                                         Date = DateTime.Now,
                                         ImagePath = PathNames.CarDefaultImages
                                     } 
                                 }
                             };

                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}