<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FridayQuizz._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">&nbsp;<br />
    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
        <div class="table"> 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <main>

    <header>
         <h1>Sports Quiz</h1>
    </header> 
    <br />
    <br />
    <br />
    <div class= "row">
    <div class= "col-md-12">
        <div class = "Question"></div>
        <p>
             1) Jaap Stam became manager of which English Championship club in June 2016?
        </p>
    </div>
    </div>
   
    <div class= "row">
    </div>
    <div class="row">
    <div class= "col-md-6">
        <p>

            <br />
            <asp:Label ID="Label1" runat="server" ></asp:Label>
             <br />
             
             <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>Reading</asp:ListItem>
                <asp:ListItem>Newcastle</asp:ListItem>
                <asp:ListItem>Derby</asp:ListItem>
                <asp:ListItem>Norwich</asp:ListItem>
            </asp:RadioButtonList>

            <%--<br />
            <asp:Label ID="Label2" runat="server" ></asp:Label>
             <br />--%>
          
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/1football.jpg" />
    
    </div>
    </div>
    <div class="row">
    <div class="col-md-12">
        <asp:Label ID="Question1Answer" runat="server"></asp:Label>
    </div>
    </div>
    <br />
    <br />


    <div class="row">
    <div class="col-md-12">
        <div class = "Question">
        <p>
           2) In which city was a young Cassius Clay born and raised?
        </p>
        </div>    
        </div></div>

        <div class="row">
        <div class="col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>Las Vegas, Nevada</asp:ListItem>
                <asp:ListItem>Philadelphia, Pennsylvania</asp:ListItem>
                <asp:ListItem>Louisville, Kentucky</asp:ListItem>
                <asp:ListItem>Grand Rapids, Michigan</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        </div>
    
    <div class="col-md-6">
        <img src="Content/Images/2Muhammad-Ali-1981-smile-billboard-1548.jpg" /></div>

  
    
    </div>

    <div class="row">
    <div class="col-md-12">
        <asp:Label ID="Question2Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>
          
      
    <div class="row">
    <div class="col-md-12">
        <div id = "Question 3"></div>
        <p>
             3) As of 2016 who is the only wild card to win the Wimbledon Gentlemen's Singles Championship?
        </p>
    </div>
    </div>
    
    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList4_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>Goran Ivanišević</asp:ListItem>
                <asp:ListItem>Marin Čilić</asp:ListItem>
                <asp:ListItem>Tomáš Berdych</asp:ListItem>
                <asp:ListItem>Richard Krajicek</asp:ListItem>
            </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
    
        <img src="Content/Images/3centre-court.jpg" />

    </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
        <asp:Label ID="Question3Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>



      
    <div class="row">
    <div class="col-md-12">
        <div id = "Question 4"></div>
        <p>
             4) Muhammad Ali's 1971 'Fight of the Century' took place in Madison Square Garden, New York City against which fellow heavyweight?
        </p>
    </div>
    </div>
    
    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList5_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>Joe Frazier</asp:ListItem>
                <asp:ListItem>Sonny Liston</asp:ListItem>
                <asp:ListItem>Ken Norton</asp:ListItem>
                <asp:ListItem>George Foreman</asp:ListItem>
            </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/4NYC-FORBES-1940x970.jpg" />

   </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
        <asp:Label ID="Question4Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>

    
    <div class="row">
    <div class="col-md-12">
        <div id = "Question 5"></div>
        <p>
            5) Which player was voted Footballer Writers' Footballer of the Year in 2015-16?
        </p>
    </div>
    </div>
    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList6" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList6_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>Eden Hazard</asp:ListItem>
                <asp:ListItem>Riyad Mahrez</asp:ListItem>
                <asp:ListItem>Alexis Sanchez</asp:ListItem>
                <asp:ListItem>Jamie Vardy</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/5images.jpg" />
    
    </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
         <asp:Label ID="Question5Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>
    


    <div class="row">
    <div class="col-md-12">
        <div id = "Question 6"></div>
        <p>
            6) Which footballer won the African Footballer of the Year award in four consecutive years between 2011 and 2014?
        </p>
    </div>
    </div>

    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList7" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList7_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>Didier Drogba</asp:ListItem>
                <asp:ListItem>Yaya Toure</asp:ListItem>
                <asp:ListItem>Victor Moses</asp:ListItem>
                <asp:ListItem>Samuel Eto'o</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/6_90010195_gettyimages-531592676.jpg" />
    </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
    <asp:Label ID="Question6Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>

 
      
    <div class="row">
    <div class="col-md-12">
        <div id = "Question 7"></div>
        <p>
         <h3>7) Where will the 2020 0lympics be held?</h3>
    </div>
    </div>
    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList8" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList8_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>CapeTown, South Africa</asp:ListItem>
                <asp:ListItem>Wellington, New Zealand</asp:ListItem>
                <asp:ListItem>Tokyo, Japan</asp:ListItem>
                <asp:ListItem>Shanghai, China</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/7Olympics-Logo.jpg" />
    </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
     <asp:Label ID="Question7Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>
      
            
    <div class="row">
    <div class="col-md-12">
        <div id = "Question 8"></div>
        <p>
         8) Which two British cyclists teamed up to win the Madison event at the Track World Championships in London?
        </p>
    </div>
    </div>

    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList9" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList9_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>Sir Bradley Wiggins and Jason Kenny</asp:ListItem>
                <asp:ListItem>Jason Kenny and Chris Froome</asp:ListItem>
                <asp:ListItem>Sir Bradley Wiggins and Mark Cavendish</asp:ListItem>
                <asp:ListItem>Chris Froome and Mark Cavendish</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/8cycling.jpg" />
    </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
     <asp:Label ID="Question8Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>

     
    <div class="row">
    <div class="col-md-12">
        <div id = "Question 9"></div>
        <p>
          <h3>9) Michael Phelps, the USA swimmer held the record for the most medals as of 2015 with 22. How many of those medals were Gold? </h3>
          
            <p>
            </p>
            <p>
            </p>
          
            <p>
            </p>
          
            <p>
            </p>
          
            <p>
            </p>
          
            </p>
    </div>
    </div>
    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList10" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList10_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/9mp.jpg" />
    </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
    <asp:Label ID="Question9Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>
 
 
    <div class="row">
    <div class="col-md-12">
        <div id = "Question 10"></div>
        <p>
           <h3>10) Thierry Henry made his professional debut with which club?</h3>
            <p>
         </p>
    </div>
    </div>

    <div class="row">
    <div class= "col-md-6">
        <p>
        <asp:RadioButtonList ID="RadioButtonList11" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList11_SelectedIndexChanged" CssClass="rbl">
                <asp:ListItem>FC Barcelona</asp:ListItem>
                <asp:ListItem>Juventus</asp:ListItem>
                <asp:ListItem>Arsenal</asp:ListItem>
                <asp:ListItem>Monaco</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    </div>
    <div class="col-md-6">
        <img src="Content/Images/10ThierryHenry.jpg" />
    </div>
    
    </div>

    <div class="row">
    <div class="col-md-12">
    <asp:Label ID="Question10Answer" runat="server"></asp:Label>
    </div>
    <br />
    <br />
    </div>

        
       <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" class = "btn btn-primary"/>
       <br />
       <br />
       
      <div id = "results">
        <p>You scored: 
          <asp:Label ID="TotalScore" runat="server"></asp:Label>
          </p>
       </div>
       </ContentTemplate>
       </asp:UpdatePanel>
      
                </div>


      <footer>
      <div></div>
      </footer>  
    
    <%--</div>--%>




  

</asp:Content>
