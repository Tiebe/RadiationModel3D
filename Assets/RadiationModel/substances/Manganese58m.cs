using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese58m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese58m";
        public override double halfLife { get; } = 65.4d;
        public override double atomicWeight { get; } = 57.94014d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron58()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.21384d, new GammaParticle(459160.0, 0.0027)), new(0.012672000000000001d, new GammaParticle(466480.0, 0.00266)), new(0.03696d, new GammaParticle(523860.0, 0.00237)), new(0.005632000000000001d, new GammaParticle(632710.0, 0.00196)), new(0.88d, new GammaParticle(810761.0, 0.00153)), new(0.14784d, new GammaParticle(863940.0, 0.00144)), new(0.016808d, new GammaParticle(925680.0, 0.00134)), new(0.010471999999999999d, new GammaParticle(1156770.0, 0.00107)), new(0.09064d, new GammaParticle(1265740.0, 0.00098)), new(0.006864d, new GammaParticle(1301100.0, 0.00095)), new(0.59224d, new GammaParticle(1323090.0, 0.00094)), new(0.00035200000000000005d, new GammaParticle(1436500.0, 0.00086)), new(0.000968d, new GammaParticle(1446500.0, 0.00086)), new(0.0015840000000000001d, new GammaParticle(1488170.0, 0.00083)), new(0.005104d, new GammaParticle(1558710.0, 0.0008)), new(0.11616d, new GammaParticle(1674720.0, 0.00074)), new(0.0007040000000000001d, new GammaParticle(1712200.0, 0.00072)), new(0.03168d, new GammaParticle(1767740.0, 0.0007)), new(0.0286d, new GammaParticle(1789590.0, 0.00069)), new(0.00035200000000000005d, new GammaParticle(1825100.0, 0.00068)), new(0.0015840000000000001d, new GammaParticle(2011700.0, 0.00062)), new(0.0015840000000000001d, new GammaParticle(2065590.0, 0.0006)), new(0.004752d, new GammaParticle(2179080.0, 0.00057)), new(0.0029920000000000003d, new GammaParticle(2226880.0, 0.00056)), new(0.003432d, new GammaParticle(2236330.0, 0.00055)), new(0.0007920000000000001d, new GammaParticle(2272990.0, 0.00055)), new(0.011175999999999998d, new GammaParticle(2422450.0, 0.00051)), new(0.001232d, new GammaParticle(2433050.0, 0.00051)), new(0.000528d, new GammaParticle(2513900.0, 0.00049)), new(0.013288d, new GammaParticle(2638150.0, 0.00047)), new(0.001056d, new GammaParticle(2699940.0, 0.00046)), new(0.008448d, new GammaParticle(2818500.0, 0.00044)), new(0.008448d, new GammaParticle(2818500.0, 0.00044)), new(0.000616d, new GammaParticle(2855200.0, 0.00043)), new(0.000264d, new GammaParticle(2876300.0, 0.00043)), new(0.000264d, new GammaParticle(3083600.0, 0.0004)), new(0.000968d, new GammaParticle(3090700.0, 0.0004)), new(0.000264d, new GammaParticle(3233200.0, 0.00038)), new(0.00017600000000000002d, new GammaParticle(3501900.0, 0.00035)), new(0.0007040000000000001d, new GammaParticle(3629800.0, 0.00034)), new(0.0007040000000000001d, new GammaParticle(3681700.0, 0.00034)), new(0.0014960000000000002d, new GammaParticle(3778100.0, 0.00033)), new(0.00017600000000000002d, new GammaParticle(3901500.0, 0.00032)), new(0.00017600000000000002d, new GammaParticle(4312700.0, 0.00029)), new(0.00035200000000000005d, new GammaParticle(4531000.0, 0.00027)), new(5.1106338880608e-06d, new GammaParticle(728.0, 1.70308)), new(5.8285623009919805e-05d, new GammaParticle(6391.0, 0.194)), new(0.0001141288878204813d, new GammaParticle(6404.0, 0.1936)), new(2.358630508159887e-05d, new GammaParticle(7082.0, 0.17507)), new(2.358630508159887e-05d, new GammaParticle(7082.0, 0.17507)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese58()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    