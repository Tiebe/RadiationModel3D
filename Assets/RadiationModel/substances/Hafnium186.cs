
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium186";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 185.9609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum186() } },

        };
    }
}
    
    