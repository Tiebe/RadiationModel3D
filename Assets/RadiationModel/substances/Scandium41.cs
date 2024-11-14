using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium41";
        public override double halfLife { get; } = 0.5963d;
        public override double atomicWeight { get; } = 40.96925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6495550.0), new Calcium41() } },

        };
    }
}
    
    