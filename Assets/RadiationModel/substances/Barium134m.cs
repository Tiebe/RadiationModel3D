using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium134m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 133.90768d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium134()), new(0.505d, new GammaParticle(121300.0, 0.01022)), new(0.99405d, new GammaParticle(604700.0, 0.00205)), new(0.9945099999999999d, new GammaParticle(624500.0, 0.00199)), new(0.99696d, new GammaParticle(795700.0, 0.00156)), new(0.99709d, new GammaParticle(810700.0, 0.00153)), new(0.048348559375072d, new GammaParticle(4966.0, 0.24967)), new(0.09062601429230747d, new GammaParticle(31816.0, 0.03897)), new(0.1669602326682157d, new GammaParticle(32193.0, 0.03851)), new(0.049110093569869714d, new GammaParticle(36482.0, 0.03399)), new(0.061485837149476884d, new GammaParticle(36827.0, 0.03367)), new(0.012375743579607168d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    