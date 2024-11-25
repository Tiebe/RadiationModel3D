using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium86m";
        public override double halfLife { get; } = 61.02d;
        public override double atomicWeight { get; } = 85.91176d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium86() }, { 0.9821d, new GammaParticle(556070.0, 0.00223) }, { 0.00046397081175000003d, new GammaParticle(1767.0, 0.70166) }, { 0.0030333143161857057d, new GammaParticle(13336.0, 0.09297) }, { 0.005838911099491253d, new GammaParticle(13396.0, 0.09255) }, { 0.0014214640719740503d, new GammaParticle(15021.0, 0.08254) }, { 0.0015863539043230405d, new GammaParticle(15070.0, 0.08227) }, { 0.00016488983234898985d, new GammaParticle(15187.0, 0.08164) } } },
            { 0.003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium86() }, { 1.0d, new BetaParticle(-1, 1166075.0) } } },

        };
    }
}
    