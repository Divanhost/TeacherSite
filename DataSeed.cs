// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using TeachApi.Models;

// namespace TchSite
// {
//     public class DataSeed
//     {
//         private readonly ApiContext _ctx;
//         public DataSeed(ApiContext ctx)
//         {
//             _ctx = ctx;
//         }
//         public void SeedData(int nCards, int nDocs, int nEvents, int nUsers,int nPhotos)
//         {
//             if (!_ctx.Documents.Any())
//             {
//                 SeedDocuments(nDocs);
//             }
//             if (!_ctx.Photos.Any())
//             {
//                 SeedPhotos(nPhotos);
//             }
//             if (!_ctx.Users.Any())
//             {
//                 SeedUsers(nUsers);
//             }
//             if (!_ctx.Events.Any())
//             {
//                 SeedEvents(nEvents);
//             }
//             if (!_ctx.Cards.Any())
//             {
//                 SeedCards(nCards);
//             }
//             _ctx.SaveChanges();
//         }
//         //Doc seeding
//         public void SeedDocuments(int nDocs)
//         {
//             List<Document> docs = BuildDocsList(nDocs);
//             foreach (var doc in docs)
//             {
//                 _ctx.Documents.Add(doc);
//             }
//         }

//         private List<Document> BuildDocsList(int nDocs)
//         {
//             var docs = new List<Document>();
//             for(int i =0;i<nDocs;i++){
//                 docs.Add(new Document{
//                     ID=i,
//                     Name=GenRndName(),
//                     Image="placeholder.png",
//                     Descrition=GenRndIpsum()
//                 });
//             }
//             return docs;
//         }
//         //Photo seeding
//             public void SeedPhotos(int n)
//         {
//             List<Photo> photos = BuildPhotosList(n);
//             foreach (var photo in photos)
//             {
//                 _ctx.Photos.Add(photo);
//             }
//         }

//         private List<Photo> BuildPhotosList(int n)
//         {
//             var photos = new List<Photo>();
//             for(int i =0;i<n;i++){
//                 photos.Add(new Photo{
//                     ID=i,
//                     Name=GenRndPhotoName(),
//                     Image="placeholder.png"
//                 });
//             }
//             return photos;
//         }
//         //Event seeding
//         public void SeedEvents(int n)
//         {
//             List<Event> events = BuildEventsList(n);
//             foreach (var ev in events)
//             {
//                 _ctx.Events.Add(ev);
//             }
//         }

//         private List<Event> BuildEventsList(int n)
//         {
//             var events = new List<Event>();
//             int a = GenRndNum(4);
//             List<Photo> plist = new List<Photo>();
//             for (int j = 0; j < a; j++)
//             {
//                 plist.Add(_ctx.Photos.FirstOrDefault(plist=>plist.ID == j));
//             }
//             for(int i =0;i<n;i++)
//             {
//                 events.Add(new Event{
//                     ID=i,
//                     Name=GenRndEventName(),
//                     Photos=plist
//                 });
//             }
//             return events;
//         }
//         // User Seeding 
//         public void SeedUsers(int n)
//         {
//             List<Document> users = BuildUsersList(n);
//             foreach (var user in users)
//             {
//                 _ctx.Users.Add(user);
//             }
//         }

//         private List<Document> BuildUsersList(int nDocs)
//         {
//             var docs = new List<Document>();
//             for(int i =0;i<nDocs;i++){
//                 docs.Add(new Document{
//                     ID=i,
//                     Name=GenRndName(),
//                     Image="placeholder.png",
//                     Descrition=GenRndIpsum()
//                 });
//             }
//             return docs;
//         }
//         // Seeding Cards
//         public void SeedDocuments(int nDocs)
//         {
//             List<Document> docs = BuildDocsList(nDocs);
//             foreach (var doc in docs)
//             {
//                 _ctx.Documents.Add(doc);
//             }
//         }

//         private List<Document> BuildDocsList(int nDocs)
//         {
//             var docs = new List<Document>();
//             for(int i =0;i<nDocs;i++){
//                 docs.Add(new Document{
//                     ID=i,
//                     Name=GenRndName(),
//                     Image="placeholder.png",
//                     Descrition=GenRndIpsum()
//                 });
//             }
//             return docs;
//         }
//     }
// }
