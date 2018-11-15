#Code Smells - Shotgun Surgery

## What Does It Look Like?
A common example might be the steps needed for object initialization.  Let’s consider the not so humble connection object.  Typically, there are several steps needed to initialize the connection object.  These steps are also subject to periodic changes but will most likely be the same throughout the application.  Unfortunately, this commonality is not often properly leveraged.

## Why Do We Care?
If you have ever had to update such code you know how time consuming it can be to make such changes.  If you have never had to make such changes, consider yourself lucky. 

If takes time to locate every place that needs to be changed. It takes extra testing time to ensure that every places was properly updated, and following such a pattern makes it that much more difficult to write the original code.

## What Do We Do About It?
A much better solution is to move the redundant code to a common function and that replace the multiple instances with references to the new function.  This is the basis for the Factory pattern.

