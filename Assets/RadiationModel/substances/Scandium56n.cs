using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium56n : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium56n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 55.97343d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium56() }, { 0.5425d, new GammaParticle(47700.0, 0.02599) }, { 0.37975000000000003d, new GammaParticle(140500.0, 0.00882) }, { 0.37975000000000003d, new GammaParticle(187800.0, 0.0066) }, { 0.775d, new GammaParticle(587300.0, 0.00211) }, { 0.22475d, new GammaParticle(727300.0, 0.0017) }, { 0.000298796663314152d, new GammaParticle(422.0, 2.93801) }, { 0.0038526388230319462d, new GammaParticle(4086.0, 0.30344) }, { 0.00760039223324511d, new GammaParticle(4091.0, 0.30307) }, { 0.001510654796322944d, new GammaParticle(4474.0, 0.27712) }, { 0.001510654796322944d, new GammaParticle(4474.0, 0.27712) } } },

        };
    }
}
    