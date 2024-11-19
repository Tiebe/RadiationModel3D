using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine202n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202n";
        public override double halfLife { get; } = 0.46d;
        public override double atomicWeight { get; } = 201.98925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990399999999999d, new List<RadioactiveSubstance> { new GammaParticle((585000.0, 0.00212)), new Astatine202() } },
            { 0.00096d, new List<RadioactiveSubstance> { new AlphaParticle(7961002.09), new Bismuth198() } },

        };
    }
}
    
    