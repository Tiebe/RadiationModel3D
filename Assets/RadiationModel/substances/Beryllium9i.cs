using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium9i : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium9i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 9.02763d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.526d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Beryllium8()), new(1.0d, new NeutronParticle()) } },
            { 0.43d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Helium5()), new(1.0d, new AlphaParticle(13104802.09)) } },
            { 0.044000000000000004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Beryllium9()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    