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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum89() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.612d, new GammaParticle(179200.0, 0.00692) }, { 0.134d, new GammaParticle(401600.0, 0.00309) }, { 0.047d, new GammaParticle(604600.0, 0.00205) }, { 0.039d, new GammaParticle(686600.0, 0.00181) }, { 0.028999999999999998d, new GammaParticle(835400.0, 0.00148) }, { 0.034d, new GammaParticle(1140000.0, 0.00109) }, { 0.086d, new GammaParticle(1339000.0, 0.00093) }, { 0.0014259554712d, new GammaParticle(2586.0, 0.47944) }, { 0.006808021025285504d, new GammaParticle(18250.0, 0.06794) }, { 0.012945466866867282d, new GammaParticle(18367.0, 0.0675) }, { 0.0034406550154121042d, new GammaParticle(20695.0, 0.05991) }, { 0.0039842785078472165d, new GammaParticle(20820.0, 0.05955) }, { 0.0005436234924351125d, new GammaParticle(21003.0, 0.05903) } } },
            { 0.031d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum88() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    