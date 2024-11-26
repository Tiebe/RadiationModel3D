using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony117m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony117m";
        public override double halfLife { get; } = 0.00036d;
        public override double atomicWeight { get; } = 116.9082d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony117()), new(0.00253d, new GammaParticle(12000.0, 0.10332)), new(0.015600000000000001d, new GammaParticle(58100.0, 0.02134)), new(0.052000000000000005d, new GammaParticle(162800.0, 0.00762)), new(0.6318d, new GammaParticle(197400.0, 0.00628)), new(0.35359999999999997d, new GammaParticle(202200.0, 0.00613)), new(0.1352d, new GammaParticle(250500.0, 0.00495)), new(0.078d, new GammaParticle(292600.0, 0.00424)), new(0.1222d, new GammaParticle(336900.0, 0.00368)), new(0.23399999999999999d, new GammaParticle(350000.0, 0.00354)), new(0.09359999999999999d, new GammaParticle(366000.0, 0.00339)), new(0.12480000000000001d, new GammaParticle(374500.0, 0.00331)), new(0.1066d, new GammaParticle(387200.0, 0.0032)), new(0.0858d, new GammaParticle(457100.0, 0.00271)), new(0.044199999999999996d, new GammaParticle(462400.0, 0.00268)), new(0.26d, new GammaParticle(527300.0, 0.00235)), new(0.2964d, new GammaParticle(552300.0, 0.00224)), new(0.0208d, new GammaParticle(702900.0, 0.00176)), new(0.0208d, new GammaParticle(711700.0, 0.00174)), new(0.039d, new GammaParticle(753200.0, 0.00165)), new(0.2054d, new GammaParticle(795700.0, 0.00156)), new(0.767d, new GammaParticle(1000200.0, 0.00124)), new(0.059800000000000006d, new GammaParticle(1089800.0, 0.00114)), new(0.2236d, new GammaParticle(1160000.0, 0.00107)), new(0.09359999999999999d, new GammaParticle(1310500.0, 0.00095)), new(0.42119999999999996d, new GammaParticle(1322900.0, 0.00094)), new(0.09330631387089999d, new GammaParticle(3941.0, 0.3146)), new(0.24618642562186352d, new GammaParticle(26111.0, 0.04748)), new(0.45964605231863986d, new GammaParticle(26359.0, 0.04704)), new(0.13075736708160443d, new GammaParticle(29821.0, 0.04158)), new(0.15782414206749656d, new GammaParticle(30069.0, 0.04123)), new(0.027066774985892116d, new GammaParticle(30387.0, 0.0408)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    