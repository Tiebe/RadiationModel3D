using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium44m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium44m";
        public override double halfLife { get; } = 0.15d;
        public override double atomicWeight { get; } = 43.97473d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium44() }, { 1.0d, new BetaParticle(1, 7139500.0) }, { 1.0d, new GammaParticle(1083090.0, 0.00114) }, { 0.943d, new GammaParticle(1371220.0, 0.0009) }, { 0.8590000000000001d, new GammaParticle(1561000.0, 0.00079) }, { 0.081d, new GammaParticle(2045600.0, 0.00061) }, { 0.024d, new GammaParticle(2348500.0, 0.00053) }, { 0.32899999999999996d, new GammaParticle(2833420.0, 0.00044) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 3.858860196288e-06d, new GammaParticle(477.0, 2.59925) }, { 4.836319918217455e-05d, new GammaParticle(4505.0, 0.27521) }, { 9.527817017764882e-05d, new GammaParticle(4511.0, 0.27485) }, { 1.9032481440176598e-05d, new GammaParticle(4947.0, 0.25063) }, { 1.9032481440176598e-05d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    