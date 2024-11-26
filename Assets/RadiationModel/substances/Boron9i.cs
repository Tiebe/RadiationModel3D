using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron9i : RadioactiveSubstance
    {
        public override string name { get; } = "Boron9i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 9.02906d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.46d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lithium5()), new(1.0d, new AlphaParticle(13988002.09)) } },
            { 0.44d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Beryllium8()), new(1.0d, new ProtonParticle()) } },
            { 0.0409d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Boron9()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    