using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium42";
        public override double halfLife { get; } = 0.20865d;
        public override double atomicWeight { get; } = 41.97305d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium42() }, { 1.0d, new BetaParticle(1, 6721470.0) }, { 0.5589999999999999d, new GammaParticle(611000.0, 0.00203) }, { 0.0040807d, new GammaParticle(1888400.0, 0.00066) }, { 2.0822d, new GammaParticle(511000.0, 0.00243) }, { 4.3395145284664e-06d, new GammaParticle(422.0, 2.93801) }, { 5.5662711776678657e-05d, new GammaParticle(4086.0, 0.30344) }, { 0.00010981004493327808d, new GammaParticle(4091.0, 0.30307) }, { 2.1825856610043293e-05d, new GammaParticle(4474.0, 0.27712) }, { 2.1825856610043293e-05d, new GammaParticle(4474.0, 0.27712) } } },

        };
    }
}
    