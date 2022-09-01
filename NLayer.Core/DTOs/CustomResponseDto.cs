using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
      
    public class CustomResponseDto<T>
    {
        //Api'larda döneceğiz
        //Api'lar için best practise 

        //endpointlerden geriye tek bir model dönsün ,işlem başarılı da olsa olmasa da 
        public T Data { get; set; }
        [JsonIgnore]//json'a dönüştürürkem Statuscode client'a dönmeyecek
        //Dönüceğimiz response'ın body'sinde status kodu dönmemize gerek yok ama kod içerisinde lazım
        public int StatusCode { get; set; }
        //Siz bir endpointe istek yaptığınızda mutlaka bir durum kodu almak zorundasınız

        public List<String> Errors { get; set; }

        //statik factory  methotlar geriye yeni nesneler dönsün : factory design pattern 
        //Amaç : nesne üretme olayını soyutlamak, nesne üretme olayını clientlardan almak tamamen ayrı bir yerde oluşturmak 

        public static CustomResponseDto<T> Success(int statusCode,T data)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Data = data, Errors= null };
        }

        //geriye data dönmeyen

        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode};
            //bunu gönderdiğimizde t data null olacak 
        }

        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode,Errors =errors };
        }
        //tek error 
        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error} };
        }
    }
}
