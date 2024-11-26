using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium237";
        public override double halfLife { get; } = 3943296.0d;
        public override double atomicWeight { get; } = 237.04841d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.999958d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium237()), new(0.0022140000000000003d, new GammaParticle(26344.6, 0.04706)), new(0.0007445599999999999d, new GammaParticle(33196.0, 0.03735)), new(2.9520000000000002e-05d, new GammaParticle(42704.0, 0.02903)), new(3.936e-05d, new GammaParticle(43420.0, 0.02855)), new(1.64e-05d, new GammaParticle(55560.0, 0.02232)), new(0.032799999999999996d, new GammaParticle(59540.9, 0.02082)), new(1.5744000000000001e-06d, new GammaParticle(69760.0, 0.01777)), new(3.1488000000000002e-06d, new GammaParticle(75800.0, 0.01636)), new(1.968e-05d, new GammaParticle(98970.0, 0.01253)), new(1.0495999999999999e-05d, new GammaParticle(102980.0, 0.01204)), new(3.28e-06d, new GammaParticle(125300.0, 0.00989)), new(0.45799999999999996d, new GammaParticle(17136.0, 0.07235)), new(0.129d, new GammaParticle(97078.0, 0.01277)), new(0.205d, new GammaParticle(101068.0, 0.01227)), new(0.0747d, new GammaParticle(114160.0, 0.01086)), new(0.1d, new GammaParticle(115608.0, 0.01072)), new(0.025699999999999997d, new GammaParticle(117470.0, 0.01055)) } },
            { 4.2e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium233()), new(1.0d, new AlphaParticle(6769602.09)), new(7.3e-08d, new GammaParticle(181800.0, 0.00682)), new(6.7e-07d, new GammaParticle(198610.0, 0.00624)), new(2.9e-07d, new GammaParticle(205050.0, 0.00605)), new(3.3e-06d, new GammaParticle(228560.0, 0.00542)), new(4.6e-08d, new GammaParticle(241000.0, 0.00514)), new(1.47e-06d, new GammaParticle(258460.0, 0.0048)), new(1.66e-06d, new GammaParticle(261660.0, 0.00474)), new(9.2e-06d, new GammaParticle(280400.0, 0.00442)), new(6.6e-06d, new GammaParticle(298890.0, 0.00415)), new(2.7e-07d, new GammaParticle(305400.0, 0.00406)), new(2.5e-06d, new GammaParticle(313340.0, 0.00396)), new(5.500000000000001e-06d, new GammaParticle(320750.0, 0.00387)), new(1.6e-07d, new GammaParticle(411100.0, 0.00302)), new(3.1e-07d, new GammaParticle(463100.0, 0.00268)), new(6.3e-07d, new GammaParticle(503900.0, 0.00246)), new(7.3e-08d, new GammaParticle(521100.0, 0.00238)), new(1.0519015122499999e-06d, new GammaParticle(16678.0, 0.07434)), new(6.110502684486352e-07d, new GammaParticle(94657.0, 0.0131)), new(9.781499414897314e-07d, new GammaParticle(98439.0, 0.0126)), new(3.5289244602208137e-07d, new GammaParticle(111238.0, 0.01115)), new(4.7358166256163327e-07d, new GammaParticle(112645.0, 0.01101)), new(1.2068921653955183e-07d, new GammaParticle(114446.0, 0.01083)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    