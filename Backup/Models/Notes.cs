﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPXMobile.Models
{
    public class Notes
    {

        private IUseApiNotes ApiServicesNotes
        {
            get;
            set;
        }


        /// <summary>
        /// Returns Notes by account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static WipService.getAccountNotesResponse GetAccountNotes(string id)
        {
            ApiServiceNotes notes = new ApiServiceNotes();
            return notes.GetAccountNotes(id);
        }


        /// <summary>
        /// Insert Notes by account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static void InsertNotes(string id, string type, string note)
        {
            ApiServiceNotes notes = new ApiServiceNotes();
            notes.InsertNote(id, type, note);
        }

        /// <summary>
        /// Update Notes by account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static void UpdateNotes(string id, string type, string note,int noteId)
        {
            ApiServiceNotes notes = new ApiServiceNotes();
            notes.UpdateNote(id, type, note,noteId);
        }

        /// <summary>
        /// Delete Notes by account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static void DeleteNotes(int noteId)
        {
            ApiServiceNotes notes = new ApiServiceNotes();
            notes.DeleteNote(noteId);
        }


        /// <summary>
        /// Get Type Notes by account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static WipService.getNoteTypesResponse GetTypes()
        {
            ApiServiceNotes notes = new ApiServiceNotes();
            return notes.GetTypeNotes();
        }




        //  The interface and helper class below 
        //  create an abstract wrapper around such a type 

        public interface IUseApiNotes
        {
            WipService.getAccountNotesResponse GetAccountNotes(string id);
            WipService.getNoteTypesResponse GetTypeNotes();
            void InsertNote(string id, string type, string note);
            void UpdateNote(string id, string type, string note, int noteId);
            void DeleteNote(int noteId);
        }


        public class ApiServiceNotes : IUseApiNotes
        {


            /// <summary>
            /// Returns Notes by account
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public WipService.getAccountNotesResponse GetAccountNotes(string id)
            {
                var port = Models.Util.Port();
                WipService.getAccountNotesRequest acreq = new MPXMobile.WipService.getAccountNotesRequest();
                acreq.accountId = int.Parse(id);
                var account = port.getAccountNotes(acreq);
                return account;
            }


            /// <summary>
            /// Returns Type Notes 
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public WipService.getNoteTypesResponse GetTypeNotes()
            {
                var port = Models.Util.Port();
                WipService.getNoteTypesRequest types = new MPXMobile.WipService.getNoteTypesRequest();
                var account = port.getNoteTypes(types);
                return account;
            }



           /// <summary>
           /// Inserts a note to a specific donor account
           /// </summary>
           /// <param name="id">Account Id</param>
           /// <param name="type">Type of note</param>
           /// <param name="note">Stirng</param>
            public void InsertNote(string id, string type, string note)
            {
                var port = Models.Util.Port();
                WipService.accountNote insNotes = new MPXMobile.WipService.accountNote();
                insNotes.accountId = int.Parse(id);
                insNotes.note = HttpContext.Current.User.Identity.Name+" wrote: "+note;
                insNotes.noteType = type;
                insNotes.addDate = DateTime.Now;
                insNotes.nextActionNote = "NULL";
                insNotes.addUserId = 18;
                insNotes.modifiedDate = DateTime.Now;
                insNotes.modifiedUserId = 18;
                insNotes.nextDate = DateTime.Now;
                WipService.insertAccountNoteRequest insNotesInf = new MPXMobile.WipService.insertAccountNoteRequest();
                insNotesInf.accountNote = insNotes;
                var account = port.insertAccountNote(insNotesInf);

            }


            /// <summary>
            /// Modify a note to a specific donor account
            /// </summary>
            /// <param name="id">Account Id</param>
            /// <param name="type">Type of note</param>
            /// <param name="note">Stirng</param>
            public void UpdateNote(string id, string type, string note,int noteId)
            {
                var port = Models.Util.Port();
                WipService.accountNote insNotes = new MPXMobile.WipService.accountNote();
                insNotes.noteId = noteId;
                insNotes.accountId = int.Parse(id);
                insNotes.note = HttpContext.Current.User.Identity.Name + " wrote: " + note;
                insNotes.noteType = type;
                insNotes.addDate = DateTime.Now;
                insNotes.nextActionNote = "NULL";
                insNotes.addUserId = 18;
                insNotes.modifiedDate = DateTime.Now;
                insNotes.modifiedUserId = 18;
                insNotes.nextDate = DateTime.Now;
                WipService.updateAccountNoteRequest insNotesInf = new MPXMobile.WipService.updateAccountNoteRequest();
                insNotesInf.accountNote = insNotes;
                var account = port.updateAccountNote(insNotesInf);

            }


            /// <summary>
            /// Delete a note 
            /// </summary>
            /// <param name="id">Account Id</param>
            /// <param name="type">Type of note</param>
            /// <param name="note">Stirng</param>
            public void DeleteNote(int noteId)
            {
                var port = Models.Util.Port();
                WipService.accountNote insNotes = new MPXMobile.WipService.accountNote();
                insNotes.noteId = noteId;
                WipService.deleteAccountNoteRequest insNotesInf = new MPXMobile.WipService.deleteAccountNoteRequest();
                insNotesInf.accountNote = insNotes;
                var account = port.deleteAccountNote(insNotesInf);

            }

        }


    }
}
