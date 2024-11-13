
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium8j : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium8j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 8.03482d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.39399999999999996d, new List<RadioactiveSubstance> { new NeutronParticle(), new Beryllium7() } },

            { 0.11699999999999999d, new List<RadioactiveSubstance> { new Hydrogen3(), new Lithium5() } },

            { 0.079d, new List<RadioactiveSubstance> { new AlphaParticle(), new Helium4() } },

            { 0.069d, new List<RadioactiveSubstance> { new ProtonParticle(), new Lithium7() } },

            { 0.066d, new List<RadioactiveSubstance> { new Helium3(), new Helium5() } },

            { 0.006d, new List<RadioactiveSubstance> { new GammaParticle(), new Beryllium8() } },

        };
    }
}
    
    