# 将Git作为SVN客户端使用笔记

# Using Git as SVN Client

## 使用流程

### git svn clone

使用标准SVN目录结构获取版本库

    $ git svn clone file:///tmp/test-svn -s
    $ git svn clone file:///tmp/test-svn --stdlayout

指定SVN版本库目录结构

    $ git svn clone file:///tmp/test-svn -T trunk -b branches -t tags

Http方式获取版本库时指定用户名

    $ git svn clone file:///tmp/test-svn --username=<user>

非Http方式和Http方式获取版本库时指定用户名

    $ git svn clone svn+ssh://foo@svn.bar.com/project

### git svn rebase

等价于svn update，获取远程svn版本库更新

### git svn dcommit

将当前分支下的提交记录提交到远程svn服务器，并最后执行`git svn rebase`

最后不执行rebase

    $ git svn dcommit --no-rebase

### git svn branch

在远程svn服务器上创建远程分支

    $ git svn branch

-m, --message参数可附加说明信息
-t, --tag建立标签而非分支

### git svn log

检查服务端提交日志，可指定版本号

    $ git svn log -r n:n

### git svn show-ignore

检查服务端配置的忽略设置

以下命令可以将服务端忽略设置保存到git本地。

    $ git svn show-ignore >> .git/info/exclude
