#ifndef LOGIN_H
#define LOGIN_H

#include <QKeyEvent>
#include <QMainWindow>
#include "MainWindow.h"
#include "Information.h"

namespace Ui {
class Login;
}

class Login : public QMainWindow
{
    Q_OBJECT
    
public:
    explicit Login(QWidget *parent = 0);
    ~Login();
    void keyPressEvent(QKeyEvent *event);
    
private slots:
    void on_loginButton_clicked();
    void on_exitButton_clicked();

private:
    Ui::Login *ui;
};

#endif // LOGIN_H
