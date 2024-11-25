using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium130m";
        public override double halfLife { get; } = 207.6d;
        public override double atomicWeight { get; } = 129.90688d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9984000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium130() }, { 2.5000000000000002e-08d, new GammaParticle(14900.0, 0.08321) }, { 3.6e-05d, new GammaParticle(31500.0, 0.03936) }, { 0.07d, new GammaParticle(51180.0, 0.02423) }, { 0.34600000000000003d, new GammaParticle(80450.0, 0.01541) }, { 0.0066d, new GammaParticle(82900.0, 0.01496) }, { 0.0129d, new GammaParticle(131500.0, 0.00943) }, { 0.051d, new GammaParticle(148350.0, 0.00836) }, { 0.155d, new GammaParticle(4749.0, 0.26107) }, { 0.19544426199797477d, new GammaParticle(30625.0, 0.04048) }, { 0.3610645889487803d, new GammaParticle(30973.0, 0.04003) }, { 0.10548616322608108d, new GammaParticle(35089.0, 0.03533) }, { 0.13122478705324486d, new GammaParticle(35414.0, 0.03501) }, { 0.025738623827163784d, new GammaParticle(35818.0, 0.03462) } } },
            { 0.0016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine130() }, { 1.0d, new BetaParticle(1, 99500.0) }, { 4.1e-07d, new GammaParticle(206200.0, 0.00601) }, { 2.1000000000000002e-06d, new GammaParticle(470800.0, 0.00263) }, { 0.00013726773179436398d, new GammaParticle(4540.0, 0.27309) }, { 0.0003432272906813883d, new GammaParticle(29458.0, 0.04209) }, { 0.0006358415907398821d, new GammaParticle(29778.0, 0.04164) }, { 0.00018432793584686864d, new GammaParticle(33726.0, 0.03676) }, { 0.00022782932870672962d, new GammaParticle(34030.0, 0.03643) }, { 4.3501392859861e-05d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    