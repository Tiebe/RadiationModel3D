
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium236m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium236m";
        public override double halfLife { get; } = 81000.0d;
        public override double atomicWeight { get; } = 236.04663d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.5d, new List<RadioactiveSubstance> { new Uranium236() } },

            { 0.5d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium236() } },

        };
    }
}
    
    