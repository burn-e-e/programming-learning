// Create a timer.
System.Timers.Timer timer = new System.Timers.Timer(2000);

// Set the timer's Elapsed event handler.
timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);

// Start the timer.
timer.Start();

// Button click event handler.
private void button1_Click(object sender, EventArgs e) {
  // Set the label's text.
  label1.Text = "This label will disappear in 2 seconds.";
}

// Timer's Elapsed event handler.
private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
  // Stop the timer.
  timer.Stop();

  // Clear the label's text.
  label1.Text = "";
}
