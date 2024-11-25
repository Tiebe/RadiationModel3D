using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium228";
        public override double halfLife { get; } = 181452324.3539d;
        public override double atomicWeight { get; } = 228.03107d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium228() }, { 1.0d, new BetaParticle(-1, 22750.0) }, { 1.5000000000000002e-08d, new GammaParticle(6280.0, 0.19743) }, { 3.2e-07d, new GammaParticle(6670.0, 0.18588) }, { 0.0030399999999999997d, new GammaParticle(12750.0, 0.09724) }, { 0.016d, new GammaParticle(13520.0, 0.0917) }, { 0.0016d, new GammaParticle(15500.0, 0.07999) }, { 0.0072d, new GammaParticle(16200.0, 0.07653) }, { 0.000149d, new GammaParticle(26400.0, 0.04696) }, { 0.010426079999999999d, new GammaParticle(15349.0, 0.08078) } } },

        };
    }
}
    