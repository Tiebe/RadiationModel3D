using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium36 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium36";
        public override double halfLife { get; } = 0.341d;
        public override double atomicWeight { get; } = 35.9813d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine36() }, { 1.0d, new BetaParticle(1, 6052405.0) }, { 0.818d, new GammaParticle(1970400.0, 0.00063) }, { 0.03d, new GammaParticle(2170290.0, 0.00057) }, { 0.3d, new GammaParticle(2207800.0, 0.00056) }, { 0.32d, new GammaParticle(2433430.0, 0.00051) }, { 0.048d, new GammaParticle(2470500.0, 0.0005) }, { 0.0039000000000000003d, new GammaParticle(2699300.0, 0.00046) }, { 0.009899999999999999d, new GammaParticle(2897000.0, 0.00043) }, { 0.0204d, new GammaParticle(4178500.0, 0.0003) }, { 0.08d, new GammaParticle(4440800.0, 0.00028) }, { 0.0072d, new GammaParticle(4641000.0, 0.00027) }, { 0.0045000000000000005d, new GammaParticle(4759600.0, 0.00026) }, { 0.0034000000000000002d, new GammaParticle(4896300.0, 0.00025) }, { 0.0016d, new GammaParticle(4950000.0, 0.00025) }, { 0.0014000000000000002d, new GammaParticle(4977200.0, 0.00025) }, { 0.003d, new GammaParticle(5169500.0, 0.00024) }, { 0.0032d, new GammaParticle(5206500.0, 0.00024) }, { 0.0055000000000000005d, new GammaParticle(5367500.0, 0.00023) }, { 0.0036d, new GammaParticle(5738200.0, 0.00022) }, { 0.0016d, new GammaParticle(6585100.0, 0.00019) }, { 0.066d, new GammaParticle(6612100.0, 0.00019) }, { 0.0045000000000000005d, new GammaParticle(6730500.0, 0.00018) }, { 0.0038d, new GammaParticle(7177600.0, 0.00017) }, { 0.0013d, new GammaParticle(7531600.0, 0.00016) }, { 0.0017000000000000001d, new GammaParticle(7708200.0, 0.00016) }, { 0.00127d, new GammaParticle(7970500.0, 0.00016) }, { 0.00053d, new GammaParticle(8132600.0, 0.00015) }, { 0.00049d, new GammaParticle(9218400.0, 0.00013) }, { 2.013786688d, new GammaParticle(511000.0, 0.00243) }, { 1.1519588044307406e-06d, new GammaParticle(265.0, 4.67865) }, { 1.5863058539785107e-05d, new GammaParticle(2956.0, 0.41943) }, { 3.1418218537898806e-05d, new GammaParticle(2958.0, 0.41915) }, { 5.101649796682093e-06d, new GammaParticle(3190.0, 0.38867) }, { 5.101649796682093e-06d, new GammaParticle(3190.0, 0.38867) } } },
            { 0.00048d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine35() }, { 1.0d, new ProtonParticle() } } },
            { 3.4e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur32() }, { 1.0d, new AlphaParticle(7195339.1899999995) } } },

        };
    }
}
    