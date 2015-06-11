using Castle.DynamicProxy;
using LogModule;

namespace AOPModule
{
    /// <summary>
    /// �Զ���������
    /// </summary>
    public class CustomBaseInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            BeforeProceed(invocation);
            invocation.Proceed();
            AfterProceed();
        }

        protected virtual void BeforeProceed(IInvocation invocation)
        {
            LogHelper.WriteMsg("���÷�����"+invocation.Method.Name);
        }

        protected virtual void AfterProceed()
        {
            
        }
    }
}