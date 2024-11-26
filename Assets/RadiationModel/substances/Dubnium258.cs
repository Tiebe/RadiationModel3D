using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium258";
        public override double halfLife { get; } = 4.3d;
        public override double atomicWeight { get; } = 258.10898d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.77d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium254()), new(1.0d, new AlphaParticle(10457002.09)) } },
            { 0.23d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium258()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    