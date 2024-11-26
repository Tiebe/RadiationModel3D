using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium89";
        public override double halfLife { get; } = 1.32d;
        public override double atomicWeight { get; } = 88.93734d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum89()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.612d, new GammaParticle(179200.0, 0.00692)), new(0.134d, new GammaParticle(401600.0, 0.00309)), new(0.047d, new GammaParticle(604600.0, 0.00205)), new(0.039d, new GammaParticle(686600.0, 0.00181)), new(0.028999999999999998d, new GammaParticle(835400.0, 0.00148)), new(0.034d, new GammaParticle(1140000.0, 0.00109)), new(0.086d, new GammaParticle(1339000.0, 0.00093)), new(0.0014259554712d, new GammaParticle(2586.0, 0.47944)), new(0.006808021025285504d, new GammaParticle(18250.0, 0.06794)), new(0.012945466866867282d, new GammaParticle(18367.0, 0.0675)), new(0.0034406550154121042d, new GammaParticle(20695.0, 0.05991)), new(0.0039842785078472165d, new GammaParticle(20820.0, 0.05955)), new(0.0005436234924351125d, new GammaParticle(21003.0, 0.05903)) } },
            { 0.031d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum88()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    