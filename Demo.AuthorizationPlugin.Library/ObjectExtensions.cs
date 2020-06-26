namespace Demo.AuthorizationPlugin
{
  using System;
  using System.Collections.Generic;
  using System.Globalization;
  using System.Reflection;
  using System.Text;

  /// <summary>
  /// Расширения для упрощения работы с динамическими объектами.
  /// </summary>
  internal static class ObjectExtensions
  {
    /// <summary>
    /// Вызвать мембер объекта.
    /// </summary>
    /// <param name="instance">Экземпляр объекта.</param>
    /// <param name="invokeAttr">Параметры вызова.</param>
    /// <param name="name">Имя мембера.</param>
    /// <param name="args">Аргументы вызова мембера.</param>
    /// <returns>Результат вызова.</returns>
    internal static object InvokeMember(this object instance, BindingFlags invokeAttr, string name, object[] args)
    {
      return instance.GetType().InvokeMember(name, invokeAttr, null, instance, args, CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Вызвать метод объекта.
    /// </summary>
    /// <param name="instance">Экземпляр объекта.</param>
    /// <param name="name">Имя метода.</param>
    /// <param name="args">Аргументы вызова метода.</param>
    /// <returns>Результат вызова.</returns>
    internal static object InvokeMethod(this object instance, string name, params object[] args)
    {
      return instance.InvokeMember(BindingFlags.InvokeMethod, name, args);
    }

    /// <summary>
    /// Получить свойство объекта.
    /// </summary>
    /// <param name="instance">Экземпляр объекта.</param>
    /// <param name="name">Имя свойства.</param>
    /// <returns>Значение свойства.</returns>
    internal static object GetProperty(this object instance, string name)
    {
      return instance.InvokeMember(BindingFlags.GetProperty, name, null);
    }
    internal static object GetProperty(this object instance, string name, params object[] args)
    {
      return instance.InvokeMember(BindingFlags.GetProperty, name, args);
    }
  }
}
