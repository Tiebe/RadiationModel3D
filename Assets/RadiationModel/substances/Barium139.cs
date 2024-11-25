using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium139";
        public override double halfLife { get; } = 4975.8d;
        public override double atomicWeight { get; } = 138.90884d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum139() }, { 1.0d, new BetaParticle(-1, 1154240.0) }, { 0.23724900000000002d, new GammaParticle(165857.5, 0.00748) }, { 7.1774999999999995e-06d, new GammaParticle(1053162.0, 0.00118) }, { 9.6831e-05d, new GammaParticle(1090938.0, 0.00114) }, { 3.132e-05d, new GammaParticle(1215542.0, 0.00102) }, { 4.8807e-05d, new GammaParticle(1219044.0, 0.00102) }, { 0.00030015d, new GammaParticle(1254631.0, 0.00099) }, { 3.8628e-05d, new GammaParticle(1256772.0, 0.00099) }, { 0.00014877d, new GammaParticle(1310617.0, 0.00095) }, { 2.5317000000000002e-05d, new GammaParticle(1370509.0, 0.0009) }, { 1.6442999999999999e-06d, new GammaParticle(1381560.0, 0.0009) }, { 1.3833000000000002e-06d, new GammaParticle(1392944.0, 0.00089) }, { 0.00261d, new GammaParticle(1420478.0, 0.00087) }, { 1.71216e-05d, new GammaParticle(1476488.0, 0.00084) }, { 4.959e-07d, new GammaParticle(1517730.0, 0.00082) }, { 2.4821100000000002e-05d, new GammaParticle(1536391.0, 0.00081) }, { 2.9493e-06d, new GammaParticle(1558697.0, 0.0008) }, { 6.3944999999999995e-06d, new GammaParticle(1578146.0, 0.00079) }, { 2.4742800000000003e-05d, new GammaParticle(1595299.0, 0.00078) }, { 3.393e-06d, new GammaParticle(1600577.0, 0.00077) }, { 3.0536999999999996e-05d, new GammaParticle(1683133.0, 0.00074) }, { 1.044e-06d, new GammaParticle(1690750.0, 0.00073) }, { 1.1484e-06d, new GammaParticle(1754604.0, 0.00071) }, { 7.046999999999999e-07d, new GammaParticle(1761180.0, 0.0007) }, { 2.4794999999999997e-06d, new GammaParticle(1766346.0, 0.0007) }, { 6.786000000000001e-07d, new GammaParticle(1796970.0, 0.00069) }, { 3.9150000000000003e-07d, new GammaParticle(1894280.0, 0.00065) }, { 1.6965e-06d, new GammaParticle(1920407.0, 0.00065) }, { 1.1223e-06d, new GammaParticle(2059720.0, 0.0006) }, { 0.0062927036793898085d, new GammaParticle(5185.0, 0.23912) }, { 0.01359430288982238d, new GammaParticle(33034.0, 0.03753) }, { 0.024971166219365137d, new GammaParticle(33442.0, 0.03707) }, { 0.007436087259999765d, new GammaParticle(37908.0, 0.03271) }, { 0.009317417336779705d, new GammaParticle(38273.0, 0.03239) }, { 0.0018813300767799403d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    