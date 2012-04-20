#ifndef INFORMATION_H
#define INFORMATION_H

#include <QString>

class Information
{
public:
    static Information &getInstance();
    void setUserName(const QString &name);
    void setUserPassword(const QString &password);
    void setUserInfo(const QString &name, const QString &password);
    const QString getUserName() const;
    const QString getUserPassword() const;

private:
    static Information instance;
    QString userName;
    QString userPassword;

    Information();
    Information(const Information &);
    Information& operator=(const Information &);
};

#endif // INFORMATION_H
