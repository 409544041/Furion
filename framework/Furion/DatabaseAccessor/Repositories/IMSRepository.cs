﻿// MIT License
//
// Copyright (c) 2020-2022 百小僧, Baiqian Co.,Ltd and Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace Furion.DatabaseAccessor;

/// <summary>
/// 随机主从库仓储（主库是默认数据库）
/// </summary>
public partial interface IMSRepository : IMSRepository<MasterDbContextLocator>
{
}

/// <summary>
/// 随机主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator>
    where TMasterDbContextLocator : class, IDbContextLocator
{
    /// <summary>
    /// 获取主库仓储
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IRepository<TEntity, TMasterDbContextLocator> Master<TEntity>()
        where TEntity : class, IPrivateEntity, new();

    /// <summary>
    /// 动态获取从库（随机）
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IPrivateReadableRepository<TEntity> Slave<TEntity>()
        where TEntity : class, IPrivateEntity, new();

    /// <summary>
    /// 动态获取从库（自定义）
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IPrivateReadableRepository<TEntity> Slave<TEntity>(Func<Type> locatorHandle)
        where TEntity : class, IPrivateEntity, new();
}

/// <summary>
/// 主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
/// <typeparam name="TSlaveDbContextLocator1">从库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1>
    where TMasterDbContextLocator : class, IDbContextLocator
    where TSlaveDbContextLocator1 : class, IDbContextLocator
{
    /// <summary>
    /// 获取主库仓储
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IRepository<TEntity, TMasterDbContextLocator> Master<TEntity>()
         where TEntity : class, IPrivateEntity, new();

    /// <summary>
    /// 获取从库仓储
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IReadableRepository<TEntity, TSlaveDbContextLocator1> Slave1<TEntity>()
        where TEntity : class, IPrivateEntity, new();
}

/// <summary>
/// 主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
/// <typeparam name="TSlaveDbContextLocator1">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator2">从库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2>
    : IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1>
    where TMasterDbContextLocator : class, IDbContextLocator
    where TSlaveDbContextLocator1 : class, IDbContextLocator
    where TSlaveDbContextLocator2 : class, IDbContextLocator
{
    /// <summary>
    /// 获取从库仓储2
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IReadableRepository<TEntity, TSlaveDbContextLocator2> Slave2<TEntity>()
        where TEntity : class, IPrivateEntity, new();
}

/// <summary>
/// 主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
/// <typeparam name="TSlaveDbContextLocator1">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator2">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator3">从库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3>
    : IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2>
    where TMasterDbContextLocator : class, IDbContextLocator
    where TSlaveDbContextLocator1 : class, IDbContextLocator
    where TSlaveDbContextLocator2 : class, IDbContextLocator
    where TSlaveDbContextLocator3 : class, IDbContextLocator
{
    /// <summary>
    /// 获取从库仓储3
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IReadableRepository<TEntity, TSlaveDbContextLocator3> Slave3<TEntity>()
        where TEntity : class, IPrivateEntity, new();
}

/// <summary>
/// 主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
/// <typeparam name="TSlaveDbContextLocator1">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator2">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator3">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator4">从库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3, TSlaveDbContextLocator4>
    : IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3>
    where TMasterDbContextLocator : class, IDbContextLocator
    where TSlaveDbContextLocator1 : class, IDbContextLocator
    where TSlaveDbContextLocator2 : class, IDbContextLocator
    where TSlaveDbContextLocator3 : class, IDbContextLocator
    where TSlaveDbContextLocator4 : class, IDbContextLocator
{
    /// <summary>
    /// 获取从库仓储4
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IReadableRepository<TEntity, TSlaveDbContextLocator4> Slave4<TEntity>()
        where TEntity : class, IPrivateEntity, new();
}

/// <summary>
/// 主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
/// <typeparam name="TSlaveDbContextLocator1">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator2">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator3">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator4">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator5">从库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3, TSlaveDbContextLocator4, TSlaveDbContextLocator5>
    : IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3, TSlaveDbContextLocator4>
    where TMasterDbContextLocator : class, IDbContextLocator
    where TSlaveDbContextLocator1 : class, IDbContextLocator
    where TSlaveDbContextLocator2 : class, IDbContextLocator
    where TSlaveDbContextLocator3 : class, IDbContextLocator
    where TSlaveDbContextLocator4 : class, IDbContextLocator
    where TSlaveDbContextLocator5 : class, IDbContextLocator
{
    /// <summary>
    /// 获取从库仓储5
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IReadableRepository<TEntity, TSlaveDbContextLocator5> Slave5<TEntity>()
        where TEntity : class, IPrivateEntity, new();
}

/// <summary>
/// 主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
/// <typeparam name="TSlaveDbContextLocator1">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator2">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator3">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator4">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator5">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator6">从库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3, TSlaveDbContextLocator4, TSlaveDbContextLocator5, TSlaveDbContextLocator6>
    : IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3, TSlaveDbContextLocator4, TSlaveDbContextLocator5>
    where TMasterDbContextLocator : class, IDbContextLocator
    where TSlaveDbContextLocator1 : class, IDbContextLocator
    where TSlaveDbContextLocator2 : class, IDbContextLocator
    where TSlaveDbContextLocator3 : class, IDbContextLocator
    where TSlaveDbContextLocator4 : class, IDbContextLocator
    where TSlaveDbContextLocator5 : class, IDbContextLocator
    where TSlaveDbContextLocator6 : class, IDbContextLocator
{
    /// <summary>
    /// 获取从库仓储6
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IReadableRepository<TEntity, TSlaveDbContextLocator6> Slave6<TEntity>()
        where TEntity : class, IPrivateEntity, new();
}

/// <summary>
/// 主从库仓储
/// </summary>
/// <typeparam name="TMasterDbContextLocator">主库</typeparam>
/// <typeparam name="TSlaveDbContextLocator1">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator2">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator3">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator4">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator5">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator6">从库</typeparam>
/// <typeparam name="TSlaveDbContextLocator7">从库</typeparam>
public partial interface IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3, TSlaveDbContextLocator4, TSlaveDbContextLocator5, TSlaveDbContextLocator6, TSlaveDbContextLocator7>
    : IMSRepository<TMasterDbContextLocator, TSlaveDbContextLocator1, TSlaveDbContextLocator2, TSlaveDbContextLocator3, TSlaveDbContextLocator4, TSlaveDbContextLocator5, TSlaveDbContextLocator6>
    where TMasterDbContextLocator : class, IDbContextLocator
    where TSlaveDbContextLocator1 : class, IDbContextLocator
    where TSlaveDbContextLocator2 : class, IDbContextLocator
    where TSlaveDbContextLocator3 : class, IDbContextLocator
    where TSlaveDbContextLocator4 : class, IDbContextLocator
    where TSlaveDbContextLocator5 : class, IDbContextLocator
    where TSlaveDbContextLocator6 : class, IDbContextLocator
    where TSlaveDbContextLocator7 : class, IDbContextLocator
{
    /// <summary>
    /// 获取从库仓储7
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    /// <returns></returns>
    IReadableRepository<TEntity, TSlaveDbContextLocator7> Slave7<TEntity>()
        where TEntity : class, IPrivateEntity, new();
}