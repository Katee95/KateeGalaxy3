using System;
using System.Collections.Generic;
using System.Linq;
using Galaxy.Core.Actors;
using Galaxy.Core.Environment;
using System.Drawing;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace Galaxy.Environments.Actors
{
  
    public class BulletER : BaseActor
     {
            #region Constant
            private static int Speed = 10;
            #endregion
  
 
            #region Constructors

            public BulletER(ILevelInfo info) : base(info)
             {
                 Width = 6;
                 Height = 12;
                ActorType = ActorType.Enemy;
             }

           #endregion

           private int si;

           public int Outland
        {
            get { return si; }
            set { si = value; }
        }
           
            public override bool IsAlive
            {
                get
                {
                    return base.IsAlive;
                }
                set
                {
                    base.IsAlive = value;
                    CanDrop = value;
                }
            }
            private void bulletERRemove()
            {
               if (Position.Y > 480 || Position.Y < 0)
               {
                   IsAlive = false;
                   CanDrop = true;
               }
                
            }
 
 
  #region Overrides

 
  public override void Load()
   {
      Load(@"Assets\bullet.png");
   }


  public override void Update()
      {
          bulletERRemove();
          Position = new Point(Position.X, Position.Y + Speed);
      }

    #endregion
  
  }
} 


