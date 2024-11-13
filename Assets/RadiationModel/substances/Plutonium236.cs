
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium236";
        public override double halfLife { get; } = 90189768.816d;
        public override double atomicWeight { get; } = 236.04606d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Uranium232() } },

            { 1.9e-09d, new List<RadioactiveSubstance> {  } },

            { 2e-14d, new List<RadioactiveSubstance> { new Magnesium28(), new Lead208() } },

        };
    }
}
    
    