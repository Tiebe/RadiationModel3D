using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum199m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum199m";
        public override double halfLife { get; } = 13.6d;
        public override double atomicWeight { get; } = 198.97105d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum199() }, { 0.027999999999999997d, new GammaParticle(32000.0, 0.03875) }, { 0.8490000000000001d, new GammaParticle(391930.0, 0.00316) }, { 0.2863059790584d, new GammaParticle(11070.0, 0.112) }, { 0.020112408811991844d, new GammaParticle(65122.0, 0.01904) }, { 0.03438018600340486d, new GammaParticle(66832.0, 0.01855) }, { 0.011568023627218742d, new GammaParticle(75821.0, 0.01635) }, { 0.014876478384603303d, new GammaParticle(76725.0, 0.01616) }, { 0.00330845475738456d, new GammaParticle(77832.0, 0.01593) } } },

        };
    }
}
    