# importing required libraries
from PyQt5.QtCore import *
from PyQt5.QtWidgets import *
from PyQt5.QtGui import *
from PyQt5.QtWebEngineWidgets import *
from PyQt5.QtPrintSupport import *
import os
import sys

# creating main window class


class MainWindow(QMainWindow):

    # конструктор
    def __init__(self, *args, **kwargs):
        super(MainWindow, self).__init__(*args, **kwargs)

        # создание QWebEngineView
        self.browser = QWebEngineView()

        # установка URL-адреса браузера по умолчанию google
        self.browser.setUrl(QUrl("http://google.com"))

        # добавление действия при изменении URL-адреса
        self.browser.urlChanged.connect(self.update_urlbar)

        # добавление действия по завершении загрузки
        self.browser.loadFinished.connect(self.update_title)

        # установка браузера в качестве центрального виджета или главного окна
        self.setCentralWidget(self.browser)

        # добавление строки состояния в главное окно
        self.status = QStatusBar()

        # добавление строки состояния в главное окно
        self.setStatusBar(self.status)

        # создание QToolBar для навигации
        navtb = QToolBar("Navigation")

        # добавление этой панели инструментов в главное окно
        self.addToolBar(navtb)

        # добавление действий на панель инструментов
        # создание действия для возврата
        back_btn = QAction("Back", self)

        # подсказка о состоянии настройки
        back_btn.setStatusTip("Back to previous page")

        # добавление действия к кнопке "Назад"
        # заставляем браузер вернуться назад
        back_btn.triggered.connect(self.browser.back)

        # добавление этого действия на панель инструментов
        navtb.addAction(back_btn)

        # аналогично для дальнейших действий
        next_btn = QAction("Forward", self)
        next_btn.setStatusTip("Forward to next page")

        # добавление действия к следующей кнопке
        # заставляем браузер двигаться вперед
        next_btn.triggered.connect(self.browser.forward)
        navtb.addAction(next_btn)

        # аналогично для действия перезагрузки
        reload_btn = QAction("Reload", self)
        reload_btn.setStatusTip("Reload page")

        # добавление действия к кнопке перезагрузки
        # заставляем браузер перезагружаться
        reload_btn.triggered.connect(self.browser.reload)
        navtb.addAction(reload_btn)

        # аналогично для кнопки Home
        home_btn = QAction("Home", self)
        home_btn.setStatusTip("Go home")
        home_btn.triggered.connect(self.navigate_home)
        navtb.addAction(home_btn)

        # добавление разделителя на панели инструментов
        navtb.addSeparator()

        # создание редактирования строки для URL-адреса
        self.urlbar = QLineEdit()

        # добавление действия при нажатии клавиши возврата
        self.urlbar.returnPressed.connect(self.navigate_to_url)

        # добавление на панель инструментов
        navtb.addWidget(self.urlbar)

        # добавление действия Stop на панель инструментов
        stop_btn = QAction("Stop", self)
        stop_btn.setStatusTip("Stop loading current page")

        # добавление действия к кнопке остановки
        # заставляем браузер останавливаться
        stop_btn.triggered.connect(self.browser.stop)
        navtb.addAction(stop_btn)

        # показать все компоненты
        self.show()

    # способ обновления заголовка окна

    def update_title(self):
        title = self.browser.page().title()
        self.setWindowTitle("% s - Vlad's Browser" % title)

    # метод, вызываемый кнопкой Home

    def navigate_home(self):

        # google
        self.browser.setUrl(QUrl("http://www.google.com"))

    # метод, вызываемый строкой edit при нажатии клавиши return
    def navigate_to_url(self):

        # получение URL-адреса и преобразование его в объект QUrl
        q = QUrl(self.urlbar.text())

        # если URL-адрес схема, он пуст
        if q.scheme() == "":
            # url в html
            q.setScheme("http")

        # задайте URL-адрес для браузера
        self.browser.setUrl(q)

    # способ обновления URL-адреса
    # этот метод вызывается объектом QWebEngineView
    def update_urlbar(self, q):

        # установка текста в строку URL
        self.urlbar.setText(q.toString())

        # установка положения курсора в строке URL-адреса
        self.urlbar.setCursorPosition(0)


# создание приложения PyQt5
app = QApplication(sys.argv)

# установка имени для приложения
app.setApplicationName("Vlad's Browser")

# создание объекта главного окна
window = MainWindow()

# возврат
app.exec_()
