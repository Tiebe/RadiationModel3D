
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium147";
        public override double halfLife { get; } = 137016.0d;
        public override double atomicWeight { get; } = 146.9191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium147() } },

        };
    }
}
    
    