#include "Information.h"

Information Information::instance;

Information &Information::getInstance()
{
    return instance;
}

Information::Information()
{
}

void Information::setUserName(const QString &name)
{
    this->userName = name;
}

void Information::setUserPassword(const QString &password)
{
    this->userPassword = password;
}

void Information::setUserInfo(const QString &name, const QString &password)
{
    this->setUserName(name);
    this->setUserPassword(password);
}

const QString Information::getUserName() const
{
    return this->userName;
}

const QString Information::getUserPassword() const
{
    return this->userPassword;
}
