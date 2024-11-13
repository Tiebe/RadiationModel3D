
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium108";
        public override double halfLife { get; } = 273.0d;
        public override double atomicWeight { get; } = 107.91019d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium108() } },

        };
    }
}
    
    