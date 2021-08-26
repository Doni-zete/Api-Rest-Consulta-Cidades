using System.Collections.Generic;

namespace series.Interfaces
{
  public interface IRepositorio<T>
  {
    List<T> Lista();
    T RetornaPorId(int id);
    void Isere(T entidade);
    void Exclusive(int id);
    void Atualiza(int id, T entidade);
    int ProximoId();

  }
}