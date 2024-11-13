
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium169m";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 168.97645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.79d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium165() } },

        };
    }
}
    
    