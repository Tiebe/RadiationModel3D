
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium176m";
        public override double halfLife { get; } = 13190.4d;
        public override double atomicWeight { get; } = 175.94282d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium176() } },

            { 0.00095d, new List<RadioactiveSubstance> { new Ytterbium176() } },

        };
    }
}
    
    