import sys
from PyQt5.QtCore import QUrl
from PyQt5.QtWebEngineWidgets import QWebEngineView
from PyQt5.QtWidgets import QApplication, QMainWindow, QAction

class Browser(QMainWindow):
    def __init__(self):
        super().__init__()
        self.initUI()
        
    def initUI(self):
        self.setWindowTitle('Web Browser')
        
        # Create a QWebEngineView widget and set it as the central widget
        # of the main window
        self.webview = QWebEngineView(self)
        self.setCentralWidget(self.webview)
        
        # Create a QToolBar and add it to the main window
        toolbar = self.addToolBar('Navigation')
        
        # Add back and forward buttons to the toolbar
        back_button = QAction('Back', self)
        back_button.triggered.connect(self.webview.back)
        toolbar.addAction(back_button)
        
        forward_button = QAction('Forward', self)
        forward_button.triggered.connect(self.webview.forward)
        toolbar.addAction(forward_button)
        
        # Add a reload button to the toolbar
        reload_button = QAction('Reload', self)
        reload_button.triggered.connect(self.webview.reload)
        toolbar.addAction(reload_button)
        
        # Set the initial URL
        self.webview.setUrl(QUrl('http://www.google.com'))
        
        # Show the main window
        self.show()
        

if __name__ == '__main__':
    app = QApplication(sys.argv)
    browser = Browser()
    sys.exit(app.exec_())
