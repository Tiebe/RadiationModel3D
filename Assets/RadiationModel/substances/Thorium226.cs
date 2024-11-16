using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium226";
        public override double halfLife { get; } = 1842.0d;
        public override double atomicWeight { get; } = 226.0249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7475002.09), new Radium222() } },
            { 3.2e-14d, new List<RadioactiveSubstance> { new Oxygen18(), new Lead208() } },

        };
    }
}
    
    