## Introduction
A disk performance benchmark tool. 

## Test Method
### Sequential 
A 10-second continuous write test is conducted with a I/O size of 64MB and a maximum cumulative write of 10GB.
Write speed is calculated every 64MB and the final result is averaged. This is mainly for creating test files, and the test time not enough for an accurate result.

### 4K 
Perform a 15 second 4K random write test. The last 7.5 seconds are doubled in weight and the lower value is doubled in weight and the average is calculated. This is closer to the performance shown by the disk in a long-term usage.

### Grade
It determines weather a device is suitable for Windows To Go by testing the 4K ramdom write performance.
There are five grades, Platinum, Gold, Silver, Bronze and Steel, from high to low.
We recommend using Silver and above for Windows To Go. The higher the grade the better the experience.

### Scenario
Scenario testing simulates the operation of the disk during daily usage, such as browsing web pages, downloading files, etc. 

### Multi-threaded 4K
Reflecting the performance of the disk under high pressure. Some USB disks have high single-threaded 4K performance but low multi-threaded 4K performance, resulting in a poor experience in Windows To Go.

### Full Sequential
Full disk writes within the free space on the disk to determine the SLC cache size

More Information(Chinese only): https://bbs.luobotou.org/forum.php?mod=viewthread&tid=11206