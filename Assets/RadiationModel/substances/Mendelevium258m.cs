using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium258m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium258m";
        public override double halfLife { get; } = 4449600.0d;
        public override double atomicWeight { get; } = 258.09843d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium254()), new(1.0d, new AlphaParticle(8292802.089999999)), new(0.0020574d, new GammaParticle(56700.0, 0.02187)), new(0.03048d, new GammaParticle(71100.0, 0.01744)), new(0.0092583d, new GammaParticle(80100.0, 0.01548)), new(0.0021336d, new GammaParticle(86900.0, 0.01427)), new(0.001143d, new GammaParticle(91000.0, 0.01362)), new(0.0043434d, new GammaParticle(171100.0, 0.00725)), new(0.0037719000000000003d, new GammaParticle(189100.0, 0.00656)), new(0.0046101d, new GammaParticle(205700.0, 0.00603)), new(0.0044196d, new GammaParticle(214700.0, 0.00577)), new(0.076962d, new GammaParticle(276800.0, 0.00448)), new(0.020574d, new GammaParticle(296700.0, 0.00418)), new(0.0072009d, new GammaParticle(298100.0, 0.00416)), new(0.381d, new GammaParticle(367800.0, 0.00337)), new(0.0065532d, new GammaParticle(376800.0, 0.00329)), new(0.01524d, new GammaParticle(389100.0, 0.00319)), new(0.139446d, new GammaParticle(447900.0, 0.00277)), new(0.254346460352544d, new GammaParticle(20093.0, 0.06171)), new(0.013033702531658729d, new GammaParticle(112581.0, 0.01101)), new(0.020051850048705737d, new GammaParticle(118057.0, 0.0105)), new(0.007723210727522486d, new GammaParticle(132973.0, 0.00932)), new(0.010488120167975536d, new GammaParticle(134678.0, 0.00921)), new(0.00276490944045305d, new GammaParticle(136945.0, 0.00905)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    