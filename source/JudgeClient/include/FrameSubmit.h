#ifndef FRAMESUBMIT_H
#define FRAMESUBMIT_H

#include <QFrame>
#include <QProcess>
#include <QMessageBox>
#include <QStringList>
#include <QFileDialog>
#include <QStandardItemModel>

namespace Ui {
class FrameSubmit;
}

class FrameSubmit : public QFrame
{
    Q_OBJECT
    
public:
    explicit FrameSubmit(QWidget *parent = 0);
    ~FrameSubmit();

private:
    Ui::FrameSubmit *ui;
    QStandardItemModel *additionalModel;
    QProcess *compileProcess;

    void initAdditionalTableView();
    
private slots:
    void compileOutput();
    void on_addButton_clicked();
    void on_deleteButton_clicked();
    void on_selectButton_clicked();
    void on_submitButton_clicked();
    void on_testButton_clicked();
};

#endif // FRAMESUBMIT_H
