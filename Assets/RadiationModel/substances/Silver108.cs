using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver108 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver108";
        public override double halfLife { get; } = 142.92d;
        public override double atomicWeight { get; } = 107.90595d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9715d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium108() }, { 1.0d, new BetaParticle(-1, 822800.0) }, { 0.0176d, new GammaParticle(632980.0, 0.00196) } } },
            { 0.0285d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium108() }, { 1.0d, new BetaParticle(1, -1287900.0) }, { 9e-06d, new GammaParticle(383200.0, 0.00324) }, { 1.8e-05d, new GammaParticle(388600.0, 0.00319) }, { 0.005d, new GammaParticle(433960.0, 0.00286) }, { 2.2000000000000003e-05d, new GammaParticle(497100.0, 0.00249) }, { 3.5000000000000004e-05d, new GammaParticle(510100.0, 0.00243) }, { 0.00261d, new GammaParticle(618860.0, 0.002) }, { 3.2e-05d, new GammaParticle(880260.0, 0.00141) }, { 5.500000000000001e-06d, new GammaParticle(931120.0, 0.00133) }, { 0.000139d, new GammaParticle(1007220.0, 0.00123) }, { 1.65e-05d, new GammaParticle(1106000.0, 0.00112) }, { 3e-05d, new GammaParticle(1441140.0, 0.00086) }, { 1.05e-05d, new GammaParticle(1540000.0, 0.00081) }, { 0.005652000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.0013097403290266d, new GammaParticle(3053.0, 0.40611) }, { 0.0052047522245801895d, new GammaParticle(21020.0, 0.05898) }, { 0.009833274559947458d, new GammaParticle(21177.0, 0.05855) }, { 0.0026978477111729514d, new GammaParticle(23904.0, 0.05187) }, { 0.003156481822072353d, new GammaParticle(24070.0, 0.05151) }, { 0.0004586341108994017d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    